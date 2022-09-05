using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Tracer.Core
{
    internal class Tracer : ITracer
    {
        private ConcurrentDictionary<int, TraceThread> TracerThreads = new ConcurrentDictionary<int, TraceThread>();
        public static void DebugStackTraceOutput(StackFrame[] stackFrames)
        {
            for (int i = 0; i < stackFrames.Length; i++)
            {
                Console.WriteLine("{0} Method: {1}", i, stackFrames[i].GetMethod());
            }
        }

        private ConcurrentDictionary<int, TraceMethod> FindMethod(MethodBase methodBase, ConcurrentDictionary<int, TraceMethod> methods)
        {
            ConcurrentDictionary<int, TraceMethod> newMethod = null;
            int i = 0;
            while (i < methods.Count && newMethod == null)
            {
                if (methodBase.Name == methods[i].name)
                {

                }
            }
            return FindMethod(methodBase, );
        }

        private void AddTracer(StackFrame[] stackFrames, ConcurrentDictionary<int, TraceThread> TracerThreads)
        {
            int i = 1;
            ConcurrentDictionary<int, TraceMethod> newMethod = null;
            while (i < stackFrames.Length && newMethod == null)
            {
                int j = 0;
                while (j < TracerThreads.Count && newMethod == null)
                {
                    newMethod = FindMethod(stackFrames[i].GetMethod(), TracerThreads[j].innerMethods);
                    i++;
                }
            }
            if (newMethod == null)
            {
            }
            else
            {

            }
        }
        public void StartTrace()
        {
            var stackTrace = new StackTrace();
            StackFrame[] stackFrames = stackTrace.GetFrames();
            DebugStackTraceOutput(stackFrames);
            AddTracer(stackFrames, TracerThreads);


        }
        public void StopTrace()
        {

        }

		public TraceResult GetTraceResult()
		{
			return null;
		}
    }

}
