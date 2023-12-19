using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace TPLTest
{
	internal class Taskify<T>
	{
        public Taskify(Func<T> start)
        {
            
        }
        static Taskify<T> Run(Func<T> func)
		{
			// start func in another thread

			return new Taskify<T>(func); 
		}

		public T Result
		{
			get
			{
				// join thread
			}
		}

		public void Wait()
		{

		}

		public void ContinueWith(Action<Taskify<T>> action)
		{
			Thread t = new Thread(() => { });

			while (t.IsAlive) ;

			action(this);
		}
	}
}
