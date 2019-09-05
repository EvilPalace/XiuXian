using System;
using Game.Framework.BaseClass;
using QFramework;
using UniRx;

namespace Game.Model
{
	public class LingQiZhi : DisposeModel
	{

		/// <summary>
		/// 当前灵气值
		/// </summary>
		public ReactiveProperty<int> LingQi;
		/// <summary>
		/// 每秒变化比率
		/// </summary>
		public ReactiveProperty<int> ChangeRate;

		public LingQiZhi(int initValue, int initRate)
		{
			LingQi = new ReactiveProperty<int>(initValue).AddTo(Disposables);
			ChangeRate = new ReactiveProperty<int>(initRate).AddTo(Disposables);
			Observable.Interval(TimeSpan.FromSeconds(1)).Subscribe(_ => LingQi.Value += ChangeRate.Value).AddTo(Disposables);
		}

	}

}

