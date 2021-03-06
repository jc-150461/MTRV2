﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite;
using SQLiteNetExtensions.Attributes;

namespace MuscleTrainingRecords00
{
    [Table("Re")]//テーブル名を指定
    class RecordsModelv2
    {
        [PrimaryKey, AutoIncrement, Column("_id")]
        public int M_no { get; set; } //筋トレNo 主キー

        public string M_name { get; set; } //筋トレ名前

        public int M_weight { get; set; } //重量

        public int M_leg { get; set; } //回数

        public int M_set { get; set; } //セット数

        public DateTime M_date { get; set; } //日付





        /********************インサートメソッド RecordPage　追加**********************/
        public static void InsertRe(int m_no, string m_name, int m_weight, int m_leg, int m_set, DateTime m_date)
        {
            //データベースに接続する
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースにFoodテーブルを作成する
                    db.CreateTable<RecordsModelv2>();

                    db.Insert(new RecordsModelv2() { M_no = m_no, M_name = m_name, M_weight = m_weight, M_leg = m_leg, M_set = m_set, M_date = m_date });
                    db.Commit();
                }
                catch (Exception e)
                {
                    db.Rollback();
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }


        /*******************セレクトメソッド RecordPage　 追加*************************************/
        public static List<RecordsModelv2> SelectRe(int m_no)
        {

            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                int no = m_no;

                try
                {
                   
                    //データベースに指定したSQLを発行
                    return db.Query<RecordsModelv2>("SELECT [M_weight],[M_leg],[M_set],[M_date] FROM [Re] WHERE [M_no] =" + no);
                    // ORDER BY[M_date]
                }
                catch (Exception e)
                {

                    System.Diagnostics.Debug.WriteLine(e);
                    return null;
                }
            }
        }

        /********************デリートメソッド*************************************/
        public static void DeleteRecords(int m_no)
        {
            //データベースに接続する
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースにテーブルを作成する
                    db.CreateTable<RecordsModelv2>();

                    db.Delete<RecordsModelv2>(m_no);//デリートで渡す値は主キーじゃないといけない説
                    db.Commit();

                }
                catch (Exception e)
                {
                    db.Rollback();
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }

        /********************オールデリートメソッド*************************************/
        public static void DeleteAllRecordsd()
        {
            //データベースに接続する
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                try
                {
                    //データベースにテーブルを作成する
                    db.CreateTable<RecordsModelv2>();

                    db.DeleteAll<RecordsModelv2>();//デリートで渡す値は主キーじゃないといけない説
                    db.Commit();
                }
                catch (Exception e)
                {
                    db.Rollback();
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }

        /********************アップデートメソッド RecordPage**************************************/
        public static void UpdateRecord(int m_no, int m_weight, int m_leg, int m_set, DateTime m_date)
        {
            using (SQLiteConnection db = new SQLiteConnection(App.dbPath))
            {
                /*int no=  m_no;
                int weight = m_weight;
                int leg = m_leg;
                int set = m_set;
                TimeSpan span = m_date;
                int date = span.Days;*/

                try
                {
                    //データベースに指定したSQLを発行
                    //return db.Query<RecordsModel>("UPDATE [Records] SET [M_weight] = "+ weight +", [M_leg] = "+ leg +",[M_set] = "+ set + "WHERE [M_no] = "+ no);
                    db.CreateTable<RecordsModelv2>();

                    db.Update(new RecordsModelv2() { M_no = m_no, M_weight = m_weight, M_leg = m_leg, M_set = m_set, M_date = m_date });

                    db.Commit();
                }
                catch (Exception e)
                {

                    db.Rollback();
                    System.Diagnostics.Debug.WriteLine(e);
                }
            }
        }


    }
}