using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UniRx;

namespace Game.Model
{
	/// <summary>
	/// 角色数据
	/// </summary>
	public class RoleModel
	{
		public ReactiveProperty<JingJie> JingJie;
		public LingQiZhi LingQiZhi;
		public ReactiveProperty<int> DaoNianZhi;
		public FightProperty FightProperty;


	}
}