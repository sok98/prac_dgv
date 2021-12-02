using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prac_dgv
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        CParentGroup _PGroup { get; set; }
        List<CParent> _SelectParent { get; set; }
        List<CChild> _SelectChild { get; set; }

        int _Pidx = 0;

        private void Form1_Load(object sender, EventArgs e)
        {
            _PGroup = new CParentGroup();

            _SelectParent = new List<CParent>();    // 인덱스 0 : 마지막 선택
            _SelectChild = new List<CChild>();
        }

        /// <summary>
        /// 부모 추가 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPAdd_Click(object sender, EventArgs e)
        {
            CParent newParent = new CParent(string.Format("부모 {0}", ++_Pidx));
            for (int i = 0; i < 3; i++)
            {
                newParent.CList.Add(new CChild(string.Format("{0} - 자식 {1}", newParent.Name, i)));
            }

            // 원본 리스트에 추가
            _PGroup.PList.Add(newParent);

            // 부모 리스트 업데이트
            UpdateParent();

            // 추가한 부모 포커스 설정
            dgvParent.CurrentCell = dgvParent.Rows[dgvParent.RowCount - 1].Cells[1];

            // 선택한 부모에 맞춰 자식 리스트 업데이트
            UpdateChild();
        }

        /// <summary>
        /// 자식 추가 버튼
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCAdd_Click(object sender, EventArgs e)
        {
            if (dgvParent.SelectedRows.Count < 1)
            {
                MessageBox.Show("부모를 선택하세요.");
                return;
            }
            if (dgvParent.SelectedRows.Count > 1)
            {
                MessageBox.Show("부모를 하나만 선택하세요.");
                return;
            }

            _SelectParent[0].CList.Add(new CChild("자식 추가"));

            DisplayParent();    // 선택한 부모 count 업데이트
            UpdateChild();
        }

        #region -- Update, Display --
        /// <summary>
        /// 부모 리스트 초기화 후 업데이트
        /// </summary>
        private void UpdateParent()
        {
            dgvParent.Rows.Clear();
            foreach (CParent cp in _PGroup.PList)
            {
                dgvParent.Rows.Add(cp);
                dgvParent.Rows[dgvParent.RowCount - 1].Tag = cp;
            }
            DisplayParent();
        }
        /// <summary>
        /// 자식 리스트 초기화 후 업데이트
        /// </summary>
        private void UpdateChild()
        {
            if (_SelectParent.Count != 0 && _SelectParent[0] != null)   // 부모가 선택되어있는지 확인
            {
                dgvChild.Rows.Clear();
                foreach (CChild cc in _SelectParent[0].CList)
                {
                    dgvChild.Rows.Add(cc);
                    dgvChild.Rows[dgvChild.RowCount - 1].Tag = cc;
                }
                DisplayChild();
            }
        }

        private void DisplayParent()
        {
            lblParent.Text = string.Format("부모 리스트 ({0})", dgvParent.RowCount);

            int i = 0;
            foreach (DataGridViewRow row in dgvParent.Rows)
            {
                CParent cp = row.Tag as CParent;

                row.Cells[0].Value = ++i;
                row.Cells[1].Value = cp.IsSelect;
                row.Cells[2].Value = cp.Name;
                row.Cells[3].Value = cp.CList.Count;
            }
        }

        private void DisplayChild()
        {
            lblChild.Text = string.Format("자식 리스트 ({0})", dgvChild.RowCount);

            int i = 0;
            foreach (DataGridViewRow row in dgvChild.Rows)
            {
                CChild cc = row.Tag as CChild;

                row.Cells[0].Value = ++i;
                row.Cells[1].Value = cc.IsSelect;
                row.Cells[2].Value = cc.Name;
            }
        }
        #endregion

        private void dgvParent_Select(object sender = null, EventArgs e = null)
        {
            // _SelectParent 초기화 후 추가
            _SelectParent.Clear();
            foreach (DataGridViewRow row in dgvParent.SelectedRows)
            {
                _SelectParent.Add((CParent)row.Tag);
            }
            // 선택 부모 있으면 자식 리스트 업데이트
            if (_SelectParent.Count != 0 && _SelectParent[0] != null)
            {
                UpdateChild();
            }
        }

        private void dgvChild_Select(object sender = null, EventArgs e = null)
        {
            // _SelectChild 초기화 후 추가
            _SelectChild.Clear();
            foreach (DataGridViewRow row in dgvChild.SelectedRows)
            {
                _SelectChild.Add((CChild)row.Tag);
            }
        }
    }
}
