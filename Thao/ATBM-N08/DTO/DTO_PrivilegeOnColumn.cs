﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ATBM_N08.DTO
{
    public class DTO_PrivilegeOnColumn : INotifyPropertyChanged
    {
       

        public String TableName { get; set; }
        private bool isInsert;
        private bool isUpdate;
        private bool isSelect;
        private bool isDelete;
        private bool isInsertGrantable;
        private bool isUpdateGrantable;
        private bool isSelectGrantable;
        private bool isDeleteGrantable;
        public bool DeSelect
        {
            get; set;
        }
        public bool IsSelect
        {
            get { return isSelect; }
            set
            {
                isSelect = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("IsSelect"));
            }
        }
        public bool IsInsert
        {
            get { return isInsert; }
            set
            {
                isInsert = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("IsInsert"));
            }
        }
        public bool IsUpdate
        {
            get { return isUpdate; }
            set
            {
                isUpdate = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("IsUpdate"));
            }
        }
        public bool IsDelete
        {
            get { return isDelete; }
            set
            {
                isDelete = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("IsDelete"));
            }
        }
        public bool IsSelectGrantable
        {
            get { return isSelectGrantable; }
            set
            {
                isSelectGrantable = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("IsSelectGrantable"));
            }
        }
        public bool IsUpdateGrantable
        {
            get { return isUpdateGrantable; }
            set
            {
                isUpdateGrantable = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("IsUpdateGrantable"));
            }
        }
        public bool IsInsertGrantable
        {
            get { return isInsertGrantable; }
            set
            {
                isInsertGrantable = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("IsInsertGrantable"));
            }
        }
        public bool IsDeleteGrantable
        {
            get { return isDeleteGrantable; }
            set
            {
                isDeleteGrantable = value;
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs("IsDeleteGrantable"));
            }
        }
        public String Grantor { get; set; }
        public String Privilege { get; set; }
        public String ColumnName { get; set; }
        public DTO_PrivilegeOnColumn()
        {
            IsSelect = false;
            IsInsert = false;
            IsUpdate = false;
            IsDelete = false;
            IsSelectGrantable = false;
            IsUpdateGrantable = false;
            IsDeleteGrantable = false;
            IsInsertGrantable = false;
            DeSelect = false;
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
