# ModbusReadToolWinform

基于 [NModbus](https://www.nuget.org/packages/NModbus) 编写的 ModbusTCP 读取工具（Windows Forms）。

## 功能

- **测试连接**：校验 IP 合法性后，尝试与设备建立 TCP 连接
- **读取**：按所选功能码从指定从站读取数据，结果逐条追加显示在右侧输出区
  - 读线圈 (01)
  - 读离散输入 (02)
  - 读保持寄存器 (03)
  - 读输入寄存器 (04)
- **清空结果**：清除右侧输出区的内容

读取过程中三个按钮会自动禁用，结束后恢复，避免并发点击。

## 参数说明

| 参数 | 说明 |
| --- | --- |
| IP | 设备 IP 地址，程序启动时默认填入 `127.0.0.1` |
| 端口 | ModbusTCP 端口，程序启动时默认填入 `502` |
| 从站 ID | 目标从站的单元标识（0-255） |
| 功能码 | 下拉选择 01 / 02 / 03 / 04 |
| 起始地址 | 读取的起始地址，**0 基**（协议地址，不是 40001 这类寄存器编号） |
| 数量 | 一次读取的线圈/寄存器个数 |

## 运行要求

- Windows，.NET Framework 4.7.2（Windows 10/11 已内置，无需额外安装运行时）
- NuGet 依赖：`NModbus 3.0.81`

## 编译

用 Visual Studio 打开 `ModbusReadToolWinform.slnx` 直接生成。

或使用命令行：

```
msbuild ModbusReadToolWinform.csproj -restore -p:Configuration=Release
```
