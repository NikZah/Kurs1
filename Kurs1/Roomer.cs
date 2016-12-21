using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Kurs1
{
    class Roomer
    {
        public string Fam;
        public int Num, Square, X;
        public double Water, Electricity, Gas, Oplata, Dolg;
        public const double tariff_water = 15.88;
        public const double tariff_electricity = 4.01;
        public const double tariff_gas = 11.43;

        public Roomer()
        {
            this.Fam = "";
            this.Num = 0;
            this.Square = 0;
            this.Water = 0;
            this.Electricity = 0;
            this.Gas = 0;
            this.Oplata = 0;
            this.X = 0;
        }

        public Roomer(string fam, int num, int square, int x)
        {
            this.Fam = fam;
            this.Num = num;
            this.Square = square;
            this.X = x;
        }

        public Roomer(string fam, int num, double water, double electricity, double gas, double oplata, double dolg, int x)
        {
            this.Fam = fam;
            this.Num = num;
            this.Water = water;
            this.Electricity = electricity;
            this.Gas = gas;
            this.Oplata = oplata;
            this.Dolg = dolg;
            this.X = x;
        }

        //Подсчет оплаты за воду
        public double ItogWater(double Water)
        {
            return Water * tariff_water;
        }

        //Подсчет оплаты за электричество
        public double ItogElec(double Electricity)
        {
            return Electricity * tariff_electricity;
        }

        //Подсчет оплаты за газ
        public double ItogGas(double Gas)
        {
            return Gas * tariff_gas;
        }

        //Подсчет общей суммы коммунальных услуг
        public double TotalItog(double ItogWater, double ItogElec, double ItogGas, double Oplata)
        {
            return (ItogWater + ItogElec + ItogGas - Oplata);
        }

        //Сериализация 
        public static void Serialize()
        {
            SaveFileDialog SFD = new SaveFileDialog();
            SFD.Filter = "list (*.s)|*.s";
            if (SFD.ShowDialog() == DialogResult.OK)
            {
                Stream S = null;
                if ((S = SFD.OpenFile()) != null)
                {
                    BinaryFormatter Bf = new BinaryFormatter();
                    Bf.Serialize(S, RMList.collection);
                    Bf.Serialize(S, RMList.kommcollection);
                    S.Close();
                }
            }
        }

        //Десериализация
        public static void Deserialize()
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Filter = "list (*.s)|*.s";
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                RMList.collection.Clear();
                Stream S = null;
                if ((S = OFD.OpenFile()) != null)
                {
                    BinaryFormatter Bf = new BinaryFormatter();
                    RMList.collection = (List<Roomer>)(Bf.Deserialize(S));
                    RMList.kommcollection = (List<Roomer>)(Bf.Deserialize(S));
                    S.Close();
                }
            }
        }
    }
}
