using System;
using System.Xml.Serialization;

namespace Wms.Response.QM
{
/// <summary>
/// 入库单创建接口
/// taobao.qimen.entryorder.create
/// </summary>
[Serializable]
[XmlRoot("response")]
public class QMEntryOrderCreateResponse
{
/// <summary>
/// success|failure
/// </summary>
[XmlElement("flag", typeof(string))]
public string Flag { get; set; }
/// <summary>
/// 响应码
/// </summary>
[XmlElement("code", typeof(string))]
public string Code { get; set; }
/// <summary>
/// 响应信息
/// </summary>
[XmlElement("message", typeof(string))]
public string Message { get; set; }
/// <summary>
/// 仓储系统入库单编码
/// </summary>
[XmlElement("entryOrderId", typeof(string))]
public string EntryOrderId { get; set; }
}
}
