using System;
//等级参数类

namespace MathPractice
{
	public class clsLevels
	{
		public clsLevels(string myLevel)
		{
			MyLevel = myLevel;
		}
		public const string PreLevelName = "PreLevel";	//当前等级
		public static string PreLevel = "";
		public const string PreLevelCName = "PreLevelCN";
		public static string PreLevelCN = "";
		public const string PreLevelIName = "PreLevelInx";
		public static int PreLevelInx = 0;

		public const string Beginner = "Beginner";	//新手
		public const string Primary = "Primary";	//初级
		public const string Medium = "Medium";		//中级
		public const string Advanced = "Advanced";	//高级
		public const string Master = "Master";		//大师级
		public const string Custom = "Custom";		//自定义

		public const string BeginnerCN = "新手";	//新手
		public const string PrimaryCN = "初级";		//初级
		public const string MediumCN = "中级";		//中级
		public const string AdvancedCN = "高级";	//高级
		public const string MasterCN = "大师级";	//大师级
		public const string CustomCN = "自定义";	//自定义

		public const string MyLevelName = "Levels";	//运算符号
		private string MyLevel = "";	//当前对象的等级

		public const string OperatorName = "Operator";	//运算符号
		private string Operator = "";
		public const string AccuracyName = "Accuracy";	//精确到的小数位数
		private string Accuracy = "";
		public const string LimitTimeName = "LimitTime";	//时间限制
		private string LimitTime = "";
		public const string MaxDigitName = "MaxDigit";	//数字最大位数
		private string MaxDigit = "";
		public const string QuantityName = "Quantity";	//题目量
		private string Quantity = "";
		public string getMyLevel()
		{
			return MyLevel;
		}
		public string getOperator()
		{
			return Operator;
		}
		public string getAccuracy()
		{
			return Accuracy;
		}
		public string getLimitTime()
		{
			return LimitTime;
		}
		public string getMaxDigit()
		{
			return MaxDigit;
		}
		public string getQuantity()
		{
			return Quantity;
		}
		public void setMyLevel(string MyLevel)
		{
			this.MyLevel = MyLevel;
		}
		public void setOperator(string Operator)
		{
			this.Operator = Operator;
		}
		public void setAccuracy(string Accuracy)
		{
			this.Accuracy = Accuracy;
		}
		public void setLimitTime(string LimitTime)
		{
			this.LimitTime = LimitTime;
		}
		public void setMaxDigit(string MaxDigit)
		{
			this.MaxDigit = MaxDigit;
		}
		public void setQuantity(string Quantity)
		{
			this.Quantity = Quantity;
		}
	}
}