using Game.Framework.Interface;
using QFramework;
using UnityEngine.Experimental.XR;

namespace Game.Model
{
	public enum EnumJingJie
	{
		None = 0,
		/// <summary>
		/// 炼气
		/// </summary>
		LianQi = 1,
		/// <summary>
		/// 筑基
		/// </summary>
		ZhuJi = 2,
		/// <summary>
		/// 结丹
		/// </summary>
		JieDan = 3,
		/// <summary>
		/// 元婴
		/// </summary>
		YuanYing = 4,
		/// <summary>
		/// 化神
		/// </summary>
		HuaShen = 5,
		/// <summary>
		/// 婴变
		/// </summary>
		YinBian = 6,
		/// <summary>
		/// 问鼎
		/// </summary>
		WenDing = 7,
		/// <summary>
		/// 阴实
		/// </summary>
		YinShi = 8,
		/// <summary>
		/// 阳实
		/// </summary>
		YangShi = 9,
		/// <summary>
		/// 窥涅
		/// </summary>
		KuiNie = 10,
		/// <summary>
		/// 碎涅
		/// </summary>
		SuiNie = 11,
		/// <summary>
		/// 净涅
		/// </summary>
		JingNie = 12
	}
	public struct JingJie : IJsonHandle<JingJie>
	{

		public EnumJingJie Type;
		public int Grade;

		public JingJie(int type, int grade)
		{
			Type = (EnumJingJie) type;
			Grade = grade;
		}

		public JingJie(EnumJingJie type = EnumJingJie.None, int grade = 0)
		{
			Type = type;
			Grade = grade;
		}

		public static bool operator ==(JingJie one, JingJie other)
		{
			return one.Type == other.Type && one.Grade == other.Grade;
		}

		public static bool operator !=(JingJie one, JingJie other)
		{
			return !(one == other);
		}

		/// <summary>
		/// 境界是否想相同
		/// </summary>
		public bool IsEqualJingJie(JingJie other)
		{
			return Type == other.Type;
		}

		public string ToJson()
		{
			return string.Format("JingJie(Type:{0},Grade:{1})", (int) Type, Grade);
		}

		public JingJie FromJson(string json)
		{
			int from = json.IndexOf(':') + 1, end = json.IndexOf(',');
			if (from == 0 || end == -1) return this;
			string typeStr = json.Substring(from, end - from).Trim();
			int test = 0;
			if (int.TryParse(typeStr, out test))
				Type = (EnumJingJie) test;

			from = json.LastIndexOf(':') + 1;
			end = json.LastIndexOf(')');
			string gradeStr = json.Substring(from, end - from).Trim();
			if (int.TryParse(gradeStr, out test))
			{
				Grade = test;
			}

			return this;
		}
	}

}

