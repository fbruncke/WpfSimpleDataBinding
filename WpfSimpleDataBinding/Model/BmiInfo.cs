using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfSimpleDataBinding.Model
{
    class BmiInfo : Bindable
    {
		//public int Height { get; set; }
		private int height;

		public int Height
		{
			get { return height; }
			set { 
				height = value;
				//hej brugerflade læs mig igen
				this.NotifyUI();
			}
		}

		private int weight;

		public int Weight
		{
			get { return weight; }
			set { 
				weight = value;
				this.NotifyUI();
			}
		}

	
    }
}
