using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections ;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;

public class myText : TextBox
{
    public myText()
    {
        this.BorderStyle = BorderStyle.FixedSingle;
        this.Font = new System.Drawing.Font("Arial", 12F);
        this.Size = new Size(100,26);

    }
    private string _ColumnName = "";
    public string W_ColumnName
    {
        set
        {
            _ColumnName = value;
        }
        get
        {
            return _ColumnName;
        }
    }
   
    private string _OldValue = "";
    public string W_OldValue
    {
        set
        {
            _OldValue = value;
        }
        get
        {
            return _OldValue;
        }
    }

    public enum Tran { Tran, Display, Both, None };
    private Tran _Tran = Tran.None;
    public Tran w_Tran
    {
        get { return _Tran; }
        set
        {
            _Tran = value;
        }
    }
    
}


public  class myNumber : NumericUpDown
{
    public myNumber()
    {
     
      
    
        this.Maximum = 99999999999;

        this.Enter += new System.EventHandler(this.nudRequiredQty_Enter);
        this.Font = new System.Drawing.Font("Arial", 12F);
        this.Size = new Size(100, 26);
    }

    //[DefaultValue(2)]
    //public new int DecimalPlaces
    //{

    //    get
    //    {
    //        return base.DecimalPlaces;
    //    }
    //    set
    //    {
    //        base.DecimalPlaces = value;
    //    }
    //}
    private void nudRequiredQty_Enter(object sender, EventArgs e)
    {
        this.Select(0, this.Value.ToString().Length + 3);
    }
   
    
    
    private string _ColumnName = "";
    public string W_ColumnName
    {
        set
        {
            _ColumnName = value;
        }
        get
        {
            return _ColumnName;
        }
    }
    //*******************************
    //*******************************
    private string _OldValue = "";
    public string W_OldValue
    {
        set
        {
            _OldValue = value;
        }
        get
        {
            return _OldValue;
        }
    }

    public enum Tran { Tran, Display, Both, None };
    private Tran _Tran = Tran.None ;
    public Tran w_Tran
        {
            get { return _Tran; }
            set
            {
                _Tran = value;
            }
        }
    

}



public class myDate : DateTimePicker 
{
    public myDate()
    {
        this.Width = 100;
        this.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
        this.CustomFormat = "dd/MM/yyyy";
        this.ShowCheckBox = true;
        this.Checked = true;
        this.ShowCheckBox = true;
        this.Font = new System.Drawing.Font("Arial", 12F);
        this.Size = new Size(100, 26);
    }

    
    [DefaultValue(true)]

    public new bool ShowCheckBox
    {
        get
        {
            return base.ShowCheckBox;
        }
        set
        {
            base.ShowCheckBox = value;
        }
    }
    private string _ColumnName = "";
    public string W_ColumnName
    {
        set
        {
            _ColumnName = value;
        }
        get
        {
            return _ColumnName;
        }
    }

    private string _OldValue = "";
    public string W_OldValue
    {
        set
        {
            _OldValue = value;
        }
        get
        {
            return _OldValue;
        }
    }

    public enum Tran { Tran, Display, Both, None };
    private Tran _Tran = Tran.None;
    public Tran w_Tran
    {
        get { return _Tran; }
        set
        {
            _Tran = value;
        }
    }

}

public class myList : ComboBox 
{
    public myList()
    {
        this.AutoCompleteSource = AutoCompleteSource.ListItems;
        this.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.Font = new System.Drawing.Font("Arial", 12F);
        this.Size = new Size(100, 26);

    }
    private string _ColumnName = "";
    public string W_ColumnName
    {
        set
        {
            _ColumnName = value;
        }
        get
        {
            return _ColumnName;
        }
    }

    private string _OldValue = "";
    public string W_OldValue
    {
        set
        {
            _OldValue = value;
        }
        get
        {
            return _OldValue;
        }
    }

    public enum Tran { Tran, Display, Both, None };
    private Tran _Tran = Tran.None;
    public Tran w_Tran
    {
        get { return _Tran; }
        set
        {
            _Tran = value;
        }
    }

    public enum ValueType { TEXT,VALUE };
    private ValueType _ValueType = ValueType.TEXT ;
    public ValueType w_ValueType
    {
        get { return _ValueType; }
        set
        {
            _ValueType = value;
        }
    }

}

public class myMask : MaskedTextBox 
{
    public myMask()
    {
        this.BorderStyle = BorderStyle.FixedSingle;

    }
    private string _ColumnName = "";
    public string W_ColumnName
    {
        set
        {
            _ColumnName = value;
        }
        get
        {
            return _ColumnName;
        }
    }

    private string _OldValue = "";
    public string W_OldValue
    {
        set
        {
            _OldValue = value;
        }
        get
        {
            return _OldValue;
        }
    }

    public enum Tran { Tran, Display, Both, None };
    private Tran _Tran = Tran.None;
    public Tran w_Tran
    {
        get { return _Tran; }
        set
        {
            _Tran = value;
        }
    }

}

public class myDataGrid : DataGridView
{
    public myDataGrid()
    {
        this.RowHeadersVisible = false;
        this.EnableHeadersVisualStyles = false;
        this.AllowUserToAddRows = false;
        this.AllowUserToDeleteRows = false;
        this.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Black;
        this.ColumnHeadersDefaultCellStyle.ForeColor = Color.Chocolate;
        this.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Arial", 12F, FontStyle.Bold);
        this.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
        this.ColumnHeadersHeight = 25;
        this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
        this.BackgroundColor = System.Drawing.Color.FloralWhite;
        this.RowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 221);
        this.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(205, 205, 182);

    }

    
    private string _TableName = "";
    public string W_TableName
    {
        get
        {
            return _TableName;
        }
        set
        {
            _TableName = value;
        }
    }
    private string _PK = "";
    public string W_PK
    {
        get
        {
            return _PK;
        }
        set
        {
            _PK = value;
        }
    }
    private string _ClmName = "";
    public string W_ClmName
    {
        get
        {
            return _ClmName;
        }
        set
        {
            _ClmName = value;
        }
    }
    private string _ValName = "";
    public string W_ValName
    {
        get
        {
            return _ValName;
        }
        set
        {
            _ValName = value;
        }
    }
    private string _updValName = "";
    public string W_updValName
    {
        get
        {
            return _updValName;
        }
        set
        {
            _updValName = value;
        }
    }
}


class myGroupBox : GroupBox
{
    public myGroupBox()
    {
        this.BackColor = System.Drawing.Color.Transparent;

    }
    private string _TableName;
    public string W_TableName
    {
        get { return _TableName; }
        set
        {
            _TableName = value;
        }
    }
    private string _FormArabicName;
    public string W_FormArabicName
    {
        get { return _FormArabicName; }
        set
        {
            _FormArabicName = value;
        }
    }
    private string _PK;
    public string W_Pk
    {
        get { return _PK; }
        set
        {
            _PK = value;
        }
    }
}


class myPanal : Panel 
{
    public myPanal()
    {
        this.BackColor = System.Drawing.Color.Transparent;
        
        this.BackgroundImageLayout = ImageLayout.Stretch;
        this.Dock = DockStyle.Fill;

        this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;


    }
}

class myCombo : ComboBox
{
    public myCombo()
    {
        //this.AutoCompleteSource = AutoCompleteSource.ListItems;
        //this.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
        this.RightToLeft = RightToLeft.Yes;

    }

    //*******************************

    private string _TableName = "";
    public string W_TableName
    {
        set
        {
            _TableName = value;
        }
        get
        {
            return _TableName;
        }
    }
    //*******************************

    //*******************************
    private string _ColumnName = "";
    public string W_ColumnName
    {
        set
        {
            _ColumnName = value;
        }
        get
        {
            return _ColumnName;
        }
    }
    //*******************************
    //*******************************
    private string _OldValue = "";
    public string W_OldValue
    {
        set
        {
            _OldValue = value;
        }
        get
        {
            return _OldValue;
        }
    }
    //*******************************
    //*******************************
    private string _ColumnArabicName = "";
    public string W_ColumnArabicName
    {
        set
        {
            _ColumnArabicName = value;
        }
        get
        {
            return _ColumnArabicName;
        }
    }
    //*******************************
    //*******************************
    private bool _AcceptTran = true;
    public bool W_AcceptTran
    {
        set
        {
            _AcceptTran = value;
        }
        get
        {
            return _AcceptTran;
        }
    }
    //*******************************

    //*******************************

    private string _ValueType = "";
    public string W_ValueType
    {
        set
        {
            _ValueType = value;
        }
        get
        {
            return _ValueType;
        }
    }
    //*******************************
}