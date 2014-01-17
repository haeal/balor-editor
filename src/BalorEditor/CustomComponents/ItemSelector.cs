using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalorEditor
{
	public partial class ItemSelector : UserControl
	{
		public ItemSelector()
		{
			InitializeComponent();
			UpdateState();
		}

		private List<DataItem> _collection = new List<DataItem>();
		public List<DataItem> Collection { get { return _collection; } set { _collection = value; UpdateState(); } }

		public delegate void ItemSelectorEventHandler(object sender, int index);
		public event ItemSelectorEventHandler ItemSelectorIndexChanged;

		private int _index = 0;

		private void UpdateState()
		{
			if (Collection == null || Collection.Count == 0)
			{
				lbCurrentItem.Text = "No Items";
				btnStart.Enabled = false;
				btnPrev.Enabled = false;
				btnNext.Enabled = false;
				btnLast.Enabled = false;
				return;
			}

			btnStart.Enabled = true;
			btnPrev.Enabled = true;
			btnNext.Enabled = true;
			btnLast.Enabled = true;

			lbCurrentItem.Text = Collection[_index].ToString();

			if (_index == 0)
			{
				btnStart.Enabled = false;
				btnPrev.Enabled = false;
			}

			if (_index + 1 == Collection.Count)
			{
				btnNext.Enabled = false;
				btnLast.Enabled = false;
			}

			if (ItemSelectorIndexChanged != null)
				ItemSelectorIndexChanged.Invoke(this, _index);
		}

		private void btnStart_Click(object sender, EventArgs e)
		{
			if (Collection.Count == 0)
				return;

			_index = 0;

			UpdateState();
		}

		private void btnPrev_Click(object sender, EventArgs e)
		{
			if (Collection.Count == 0)
				return;

			if (_index == 0)
				return;

			_index--;

			UpdateState();
		}

		private void btnNext_Click(object sender, EventArgs e)
		{
			if (Collection.Count == 0)
				return;

			if (_index + 1 == Collection.Count)
				return;

			_index++;

			UpdateState();
		}

		private void btnLast_Click(object sender, EventArgs e)
		{
			if (Collection.Count == 0)
				return;

			_index = Collection.Count - 1;

			UpdateState();
		}
	}

	[Serializable]
	public class DataItem
	{
		public string Text { get; set; }
		public DataItem()
		{
		}

		public override string ToString()
		{
			return Text;
		}
	}
}
