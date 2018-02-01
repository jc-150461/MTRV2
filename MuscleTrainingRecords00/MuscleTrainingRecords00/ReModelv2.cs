using System;
using System.Collections.ObjectModel;
using SQLite;
namespace MuscleTrainingRecords00

{
    class ReModelv2
    {
        public static int key = 1;
        public ObservableCollection<Record> Records
        {
            get;
            private set;
        }

        public ReModelv2()
        {


            if (RecordsModelv2.SelectRe(key) != null)
            {
                var query = RecordsModelv2.SelectRe(key);
                Records = new ObservableCollection<Record>();


                foreach (var record in query)//拡張forループ
                {
                    Record r = new Record
                    {
                        M_no = record.M_no,
                        M_name = record.M_name,
                        M_weight = record.M_weight,
                        M_leg = record.M_leg,
                        M_set = record.M_set,
                        M_date = record.M_date
                    };
                    //一行ずつ追加
                    Records.Add(r);
                }
            }

            /*if(RecoedsModel.SelectRecords())
            {

            }*/

            else
            {
                Records = new ObservableCollection<Record>
           {
               new Record
               {
                   M_name = "データなし"
               }
           };
            }
        }
    }


}
