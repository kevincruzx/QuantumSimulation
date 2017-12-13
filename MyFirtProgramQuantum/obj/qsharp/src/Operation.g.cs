#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.MyFirtProgramQuantum", "Set (desired : Result, q1 : Qubit) : ()", new string[] { }, "C:\\Users\\kjcm_\\source\\repos\\MyFirtProgramQuantum\\MyFirtProgramQuantum\\Operation.qs", 176L, 7L, 5L)]
#line hidden
namespace Quantum.MyFirtProgramQuantum
{
    public class Set : Operation<(Result,Qubit), QVoid>
    {
        public Set(IOperationFactory m) : base(m)
        {
            this.Dependencies = new Type[] { typeof(Microsoft.Quantum.Primitive.M), typeof(Microsoft.Quantum.Primitive.X) };
        }

        public override Type[] Dependencies
        {
            get;
        }

        protected ICallable<Qubit, Result> M
        {
            get
            {
                return this.Factory.Get<ICallable<Qubit, Result>, Microsoft.Quantum.Primitive.M>();
            }
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get
            {
                return this.Factory.Get<IUnitary<Qubit>, Microsoft.Quantum.Primitive.X>();
            }
        }

        public override Func<(Result,Qubit), QVoid> Body
        {
            get => (_args) =>
            {
#line hidden
                this.Factory.StartOperation("Quantum.MyFirtProgramQuantum.Set", OperationFunctor.Body, _args);
                var __result__ = default(QVoid);
                try
                {
                    var (desired,q1) = _args;
#line 10 "C:\\Users\\kjcm_\\source\\repos\\MyFirtProgramQuantum\\MyFirtProgramQuantum\\Operation.qs"
                    var current = M.Apply<Result>(q1);
#line 11 "C:\\Users\\kjcm_\\source\\repos\\MyFirtProgramQuantum\\MyFirtProgramQuantum\\Operation.qs"
                    if ((desired != current))
                    {
#line 13 "C:\\Users\\kjcm_\\source\\repos\\MyFirtProgramQuantum\\MyFirtProgramQuantum\\Operation.qs"
                        MicrosoftQuantumPrimitiveX.Apply(q1);
                    }

#line hidden
                    return __result__;
                }
                finally
                {
#line hidden
                    this.Factory.EndOperation("Quantum.MyFirtProgramQuantum.Set", OperationFunctor.Body, __result__);
                }
            }

            ;
        }

        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Result desired, Qubit q1)
        {
            return __m__.Run<Set, (Result,Qubit), QVoid>((desired, q1));
        }
    }
}