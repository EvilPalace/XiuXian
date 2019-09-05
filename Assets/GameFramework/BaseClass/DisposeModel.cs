/*
 * 用于数据的自增长管理基类
 * 也可以处理 继承，包含等关系
 */

namespace Game.Framework.BaseClass
{
    using System;
    using UniRx;
    
    public abstract class DisposeModel : IDisposable
    {
        public CompositeDisposable Disposables = new CompositeDisposable();

        public void Dispose()
        {
            if (Disposables != null) 
                Disposables.Dispose();
        }
    }
}