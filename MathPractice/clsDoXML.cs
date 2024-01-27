using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace MathPractice
{
	class clsDoXML
	{
		public clsDoXML()
		{

		}
		public clsLevels[] levels = new clsLevels[6];

		//按规则读Xml文件
		public void ReadXMLrules()
		{
			int i = 0;
			XmlDocument doc = new XmlDocument();
			doc.Load("rules.xml");//装载XML文档 
			XmlElement root = doc.DocumentElement;
			clsLevels.PreLevel = root.Attributes[clsLevels.PreLevelName].Value;
			clsLevels.PreLevelCN = root.Attributes[clsLevels.PreLevelCName].Value;
			clsLevels.PreLevelInx = int.Parse(root.Attributes[clsLevels.PreLevelIName].Value);
			foreach (XmlElement node in root.ChildNodes)
			{
				levels[i] = new clsLevels(clsLevels.PreLevel);
				levels[i].setMyLevel(node.Attributes[clsLevels.MyLevelName].Value);
				levels[i].setOperator(node.Attributes[clsLevels.OperatorName].Value);
				levels[i].setAccuracy(node.Attributes[clsLevels.AccuracyName].Value);
				levels[i].setLimitTime(node.Attributes[clsLevels.LimitTimeName].Value);
				levels[i].setMaxDigit(node.Attributes[clsLevels.MaxDigitName].Value);
				levels[i].setQuantity(node.Attributes[clsLevels.QuantityName].Value);
				if (i < 5) i++;
			}
		}
		//按规则写XML文件
		public void WriteXMLrules()
		{
			XmlDocument doc = new XmlDocument();	// 创建doc对象
			XmlDeclaration xmldecl = doc.CreateXmlDeclaration("1.0", "gb2312", null);
			doc.AppendChild(xmldecl);
			XmlElement root = doc.CreateElement("rules"); //创建根节点rules
			root.SetAttribute(clsLevels.PreLevelName, clsLevels.PreLevel);	//设置当前等级
			root.SetAttribute(clsLevels.PreLevelCName, clsLevels.PreLevelCN);	//设置当前等级中文名
			root.SetAttribute(clsLevels.PreLevelIName, clsLevels.PreLevelInx.ToString());	//设置当前等级下标
			doc.AppendChild(root);							//加入到xml document
			for (int i = 0; i < 6; i++)
			{
				XmlElement node = doc.CreateElement("node");
				node.SetAttribute(clsLevels.MyLevelName, levels[i].getMyLevel());
				node.SetAttribute(clsLevels.OperatorName, levels[i].getOperator());
				node.SetAttribute(clsLevels.AccuracyName, levels[i].getAccuracy());
				node.SetAttribute(clsLevels.LimitTimeName, levels[i].getLimitTime());
				node.SetAttribute(clsLevels.MaxDigitName, levels[i].getMaxDigit());
				node.SetAttribute(clsLevels.QuantityName, levels[i].getQuantity());
				root.AppendChild(node);
			}
			doc.Save("rules.xml");   // 保存文件
		}
	}
}
