using Game.Framework.BaseClass;
using UniRx;

namespace Game.Model
{
    /// <summary>
    /// 战斗属性
    /// </summary>
    public class FightProperty : DisposeModel
    {
        public ReactiveProperty<int> HP;
        public ReactiveProperty<int> MP;
        public ReactiveProperty<int> Attack;
        public ReactiveProperty<int> Defense;
        public ReactiveProperty<int> Speed;

        public FightProperty(int initHP, int initMP, int initAttack, int initDefense, int initSpeed)
        {
            HP = new ReactiveProperty<int>(initHP).AddTo(Disposables);
            MP = new ReactiveProperty<int>(initMP).AddTo(Disposables);
            Attack = new ReactiveProperty<int>(initAttack).AddTo(Disposables);
            Defense = new ReactiveProperty<int>(initDefense).AddTo(Disposables);
            Speed = new ReactiveProperty<int>(initSpeed).AddTo(Disposables);
        }
    }
}