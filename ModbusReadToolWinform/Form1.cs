using NModbus;
using System;
using System.Net.Sockets;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ModbusReadToolWinform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// 禁用按钮
        /// </summary>
        private void DisableButtons()
        {
            btnRead.Enabled = false;
            btnClear.Enabled = false;
            btnTestConnection.Enabled = false;
        }

        /// <summary>
        /// 启用按钮
        /// </summary>
        private void EnableButtons()
        {
            btnRead.Enabled = true;
            btnClear.Enabled = true;
            btnTestConnection.Enabled = true;
        }

        /// <summary>
        /// 验证ip合法性
        /// </summary>
        /// <param name="ipAddress"></param>
        /// <returns></returns>
        private bool IsValidIPAddress(string ipAddress)
        {
            string pattern = @"^((25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)\.){3}(25[0-5]|2[0-4][0-9]|[01]?[0-9][0-9]?)$";
            Regex regex = new Regex(pattern);
            return regex.IsMatch(ipAddress);
        }

        /// <summary>
        /// 读取
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRead_Click(object sender, EventArgs e)
        {
            //点击按钮后就禁用
            DisableButtons();

            try
            {
                #region 定义初始的变量

                //ip
                string ip = txtIp.Text;
                //port
                int port = Convert.ToInt32(txtPort.Text);
                //Slaveid
                byte slaveId = Convert.ToByte(txtSlaveId.Text);
                //Function，下拉框第 1 项对应功能码 01，依此类推
                int function = cboFunctionCode.SelectedIndex + 1;
                //Address
                ushort address = Convert.ToUInt16(txtStartAddress.Text);
                //Quantity
                ushort quantity = Convert.ToUInt16(numQuantity.Value);

                #endregion

                #region 核心逻辑
                try
                {
                    if (!IsValidIPAddress(ip))
                    {
                        MessageBox.Show("输入的IP地址不合法！！请重新输入！");
                        txtIp.Clear();
                        return;
                    }

                    using (var client = new TcpClient(ip, port))
                    {
                        //使用NModbus工厂创建NModbus主站
                        var factory = new ModbusFactory();
                        var master = factory.CreateMaster(client);

                        switch (function)
                        {
                            case 1:
                                var coils = master.ReadCoils(slaveId, address, quantity);
                                for (int i = 0; i < coils.Length; i++)
                                {
                                    txtOutput.AppendText($"线圈地址 {address + i}: {coils[i]}\r\n");
                                }
                                break;
                            case 2:
                                var inputs = master.ReadInputs(slaveId, address, quantity);
                                for (int i = 0; i < inputs.Length; i++)
                                {
                                    txtOutput.AppendText($"输入状态地址 {address + i}: {inputs[i]}\r\n");
                                }
                                break;
                            case 3:
                                var holdingRegisters = master.ReadHoldingRegisters(slaveId, address, quantity);
                                for (int i = 0; i < holdingRegisters.Length; i++)
                                {
                                    txtOutput.AppendText($"保持寄存器地址 {address + i}: {holdingRegisters[i]}\r\n");
                                }
                                break;
                            case 4:
                                var inputRegisters = master.ReadInputRegisters(slaveId, address, quantity);
                                for (int i = 0; i < inputRegisters.Length; i++)
                                {
                                    txtOutput.AppendText($"输入寄存器地址 {address + i}: {inputRegisters[i]}\r\n");
                                }
                                break;
                            default:
                                // 功能码由下拉框提供，正常不会走到这里
                                txtOutput.AppendText("未知的函数代码。\r\n");
                                break;
                        }
                    }
                }
                catch (NModbus.SlaveException ex)
                {
                    if (ex.FunctionCode == 129)
                    {
                        MessageBox.Show("地址数量超过可读取的数量！！！");
                    }
                    else if (ex.FunctionCode == 130 || ex.FunctionCode == 131 || ex.FunctionCode == 132)
                    {
                        MessageBox.Show("功能码和从站不匹配！！");
                    }
                    else
                    {
                        MessageBox.Show(ex.Message);
                        txtOutput.AppendText(ex.Message);
                    }
                }
                #endregion
            }
            catch (Exception ex)
            {
                MessageBox.Show($"系统发生异常，详情为{ex.Message}");
                txtOutput.AppendText(ex.Message);
            }
            finally
            {
                //启用按钮
                EnableButtons();
            }
        }

        /// <summary>
        /// 窗体加载，填入默认的IP和端口，避免重复输入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            txtIp.Text = "127.0.0.1";
            txtPort.Text = "502";
        }

        /// <summary>
        /// 清空结果
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Clear();
        }

        /// <summary>
        /// 测试连接
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTestConnection_Click(object sender, EventArgs e)
        {
            try
            {
                //ip
                string ip = txtIp.Text;
                //port
                int port = Convert.ToInt32(txtPort.Text);

                if (!IsValidIPAddress(ip))
                {
                    MessageBox.Show("输入的IP地址不合法！！请重新输入！");
                    txtIp.Text = string.Empty;
                    return;
                }

                try
                {
                    using (var client = new TcpClient(ip, port))
                    {
                        MessageBox.Show("连接成功！！！");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("IP或Port不能为空！！");
            }
        }
    }
}
