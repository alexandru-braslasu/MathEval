using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MathEval
{
    struct Calculati
    {
        public int nr1, nr2, nr3, nr4;
    }
    struct aflatix
    {
        public int nr1, nr2, nr3, nr;
    }
    struct interval
    {
        public int x, y;
    }
    struct prim
    {
       public int nr1, nr2;
    }
    struct procent
    {
        public int nr1, nr2, nr3;
    }
    struct elevi
    {
        public int nota4, nota5, nota6, nota7, nota8, nota9, nota10;
    }
    struct cuvinte 
    {
        public int nr1, nr2, nr3, nr4, nr5, nr6;
    }
    public partial class test : Form
    {
        Random randomizer = new Random();
        int cheat = 0;
        int corectea6 = 0;
        int corecteb6 = 0;
        int[] solutie = new int[13];
        int[] corecte = new int[13];
        int[] corectea = new int[7];
        int[] corecteb = new int[7];
        public test()
        {
            InitializeComponent();
            Calculati s1p1 = new Calculati();
            s1p1.nr1 = randomizer.Next(2, 100);
            s1p1.nr2 = randomizer.Next(2, 10);
            s1p1.nr1 *= s1p1.nr2;
            s1p1.nr3 = randomizer.Next(2, 10);
            s1p1.nr4 = randomizer.Next(2, 10);
            S1P1.Text = "1. Calculati: " + s1p1.nr1 + ":" + s1p1.nr2 + "-" + s1p1.nr3 + "*" + s1p1.nr4;
            int key, sol;
            key = randomizer.Next(1, 5);
            sol = s1p1.nr1 / s1p1.nr2 - s1p1.nr3 * s1p1.nr4;
            if (key == 1)
            {
                corecte[1] = 1 << 3;
                S1P1RA.Text = sol + " ";
                S1P1RB.Text = randomizer.Next(sol + 1, sol + 10) + " ";
                S1P1RC.Text = randomizer.Next(sol - 10, sol - 1) + " ";
                S1P1RD.Text = randomizer.Next(sol + 11, sol + 20) + " ";
            }
            else
            if (key == 2)
            {
                corecte[1] = 1 << 2;
                S1P1RB.Text = sol + " ";
                S1P1RA.Text = randomizer.Next(sol + 1, sol + 10) + " ";
                S1P1RC.Text = randomizer.Next(sol - 10, sol - 1) + " ";
                S1P1RD.Text = randomizer.Next(sol + 11, sol + 20) + " ";
            }
            else
            if (key == 3)
            {
                corecte[1] = 1 << 1;
                S1P1RC.Text = sol + " ";
                S1P1RB.Text = randomizer.Next(sol + 1, sol + 10) + " ";
                S1P1RA.Text = randomizer.Next(sol - 10, sol - 1) + " ";
                S1P1RD.Text = randomizer.Next(sol + 11, sol + 20) + " ";
            }
            else
            if (key == 4)
            {
                corecte[1] = 1;
                S1P1RD.Text = sol + " ";
                S1P1RB.Text = randomizer.Next(sol + 1, sol + 10) + " ";
                S1P1RC.Text = randomizer.Next(sol - 10, sol - 1) + " ";
                S1P1RA.Text = randomizer.Next(sol + 11, sol + 20) + " ";
            }
            aflatix s1p2 = new aflatix();
            s1p2.nr = randomizer.Next(-20, 20);
            if (s1p2.nr == 0 || s1p2.nr == 1 || s1p2.nr == -1)
                s1p2.nr = 12;
            s1p2.nr1 = randomizer.Next(2, 10);
            s1p2.nr2 = s1p2.nr*s1p2.nr1;
            s1p2.nr3 = randomizer.Next(2, 10);
            S1P2.Text = "2. Dacă " + s1p2.nr1 + "*x=" + s1p2.nr2 + ", atunci " + s1p2.nr3 + "*x=?";
            key = randomizer.Next(1, 5);
            sol = s1p2.nr3 * s1p2.nr;
            if (key == 1)
            {
                corecte[2] = 1 << 3;
                S1P2RA.Text = sol + " ";
                S1P2RB.Text = s1p2.nr + " ";
                S1P2RC.Text = s1p2.nr3 * s1p2.nr * s1p2.nr1 + " ";
                S1P2RD.Text = sol * s1p2.nr + " ";
            }
            else
            if (key == 2)
            {
                corecte[2] = 1 << 2;
                S1P2RB.Text = sol + " ";
                S1P2RA.Text = sol * s1p2.nr + " ";
                S1P2RC.Text = s1p2.nr + " ";
                S1P2RD.Text = s1p2.nr3 * s1p2.nr * s1p2.nr1 + " ";
            }
            else
            if (key == 3)
            {
                corecte[2] = 1 << 1;
                S1P2RC.Text = sol + " ";
                S1P2RB.Text = s1p2.nr3 * s1p2.nr * s1p2.nr1 + " ";
                S1P2RA.Text = sol * s1p2.nr + " ";
                S1P2RD.Text = s1p2.nr + " ";
            }
            else
            if (key == 4)
            {
                corecte[2] = 1;
                S1P2RD.Text = sol + " ";
                S1P2RB.Text = sol * s1p2.nr + " ";
                S1P2RC.Text = s1p2.nr3 * s1p2.nr * s1p2.nr1 + " ";
                S1P2RA.Text = s1p2.nr + " ";
            }
            interval s1p3 = new interval();
            s1p3.x = randomizer.Next(-6, -1);
            s1p3.y = randomizer.Next(2, 10);
            S1P3.Text = "3. Produsul numerelor întregi negative din intervalul [" + s1p3.x + "," + s1p3.y + ") este:";
            sol = 1;
            for (int i = s1p3.x; i< 0; i++)
                sol *= i;
            key = randomizer.Next(1, 5);
            if (key == 1)
            {
                corecte[3] = 1 << 3;
                S1P3RA.Text = sol + " ";
                S1P3RB.Text = sol * (-1) + " ";
                S1P3RC.Text = sol / s1p3.x + " ";
                S1P3RD.Text = 0 + " ";
            }
            else
            if (key == 2)
            {
                corecte[3] = 1 << 2;
                S1P3RB.Text = sol + " ";
                S1P3RA.Text = 0 + " ";
                S1P3RC.Text = sol * (-1) + " ";
                S1P3RD.Text = sol / s1p3.x + " ";
            }
            else
            if (key == 3)
            {
                corecte[3] = 1 << 1;
                S1P3RC.Text = sol + " ";
                S1P3RB.Text = sol / s1p3.x + " ";
                S1P3RA.Text = 0 + " ";
                S1P3RD.Text = sol * (-1) + " ";
            }
            else
            if (key == 4)
            {
                corecte[3] = 1;
                S1P3RD.Text = sol + " ";
                S1P3RB.Text = sol * (-1) + " ";
                S1P3RC.Text = 0 + " ";
                S1P3RA.Text = sol / s1p3.x + " ";
            }
            prim s1p4 = new prim();
            s1p4.nr1 = randomizer.Next(2, 20);
            s1p4.nr2 = randomizer.Next(2, 20);
            S1P4.Text = "4. Numărul de divizori primi ai lui " + s1p4.nr2 * s1p4.nr1 + " este:";
            int d = 2, nr = 0, a = s1p4.nr1 * s1p4.nr2,nrx=1;
            for (int i = 2; i <= a; i++)
                if (a % i == 0) nrx++;
            while (a != 1)
            {
                if (a % d == 0)
                {
                    ++nr;
                    while (a % d == 0)
                        a /= d;
                }
                ++d;
            }
            key = randomizer.Next(1, 5);
            sol = nr;
            if (key == 1)
            {
                corecte[4] = 1 << 3;
                S1P4RA.Text = sol + " ";
                S1P4RB.Text = (sol + 1) + " ";
                S1P4RC.Text = (sol - 1) + " ";
                S1P4RD.Text = nrx + " ";
            }
            else
           if (key == 2)
            {
                corecte[4] = 1 << 2;
                S1P4RB.Text = sol + " ";
                S1P4RA.Text = nrx + " ";
                S1P4RC.Text = (sol + 1) + " ";
                S1P4RD.Text = (sol - 1) + " ";
            }
            else
           if (key == 3)
            {
                corecte[4] = 1 << 1;
                S1P4RC.Text = sol + " ";
                S1P4RB.Text = (sol - 1) + " ";
                S1P4RA.Text = nrx + " ";
                S1P4RD.Text = (sol + 1) + " ";
            }
            else
           if (key == 4)
            {
                corecte[4] = 1;
                S1P4RD.Text = sol + " ";
                S1P4RB.Text = (sol + 1) + " ";
                S1P4RC.Text = nrx + " ";
                S1P4RA.Text = (sol - 1) + " ";
            }
            procent s1p5 = new procent();
            s1p5.nr1 = randomizer.Next(3, 10);
            s1p5.nr2 = randomizer.Next(5, 10);
            s1p5.nr3 = s1p5.nr2 * 10;
            S1P5.Text = "5. Numărul care reprezintă " + (s1p5.nr1 * 10) + "% din " + s1p5.nr3 + " este:";
            sol = s1p5.nr1 * s1p5.nr2;
            key = randomizer.Next(1, 5);
            if (key == 1)
            {
                corecte[5] = 1 << 3;
                S1P5RA.Text = sol + " ";
                S1P5RB.Text = s1p5.nr1 * 10 + " ";
                S1P5RC.Text = s1p5.nr2 * 10 + " ";
                S1P5RD.Text = (sol + 5) + " ";
            }
            else
           if (key == 2)
            {
                corecte[5] = 1 << 2;
                S1P5RB.Text = sol + " ";
                S1P5RA.Text = (sol + 5) + " ";
                S1P5RC.Text = s1p5.nr1 * 10 + " ";
                S1P5RD.Text = s1p5.nr2 * 10 + " ";
            }
            else
           if (key == 3)
            {
                corecte[5] = 1 << 1;
                S1P5RC.Text = sol + " ";
                S1P5RB.Text = s1p5.nr2 * 10 + " ";
                S1P5RA.Text = (sol + 5) + " ";
                S1P5RD.Text = s1p5.nr1 * 10 + " ";
            }
            else
           if (key == 4)
            {
                corecte[5] = 1;
                S1P5RD.Text = sol + " ";
                S1P5RB.Text = s1p5.nr1 * 10 + " ";
                S1P5RC.Text = (sol + 5) + " ";
                S1P5RA.Text = s1p5.nr2 * 10 + " ";
            }
            elevi s1p6 = new elevi();
            s1p6.nota4 = randomizer.Next(1, 4);nota4.Text = s1p6.nota4 + " ";
            s1p6.nota5 = randomizer.Next(1, 5);nota5.Text = s1p6.nota5 + " ";
            s1p6.nota6 = randomizer.Next(2, 4);nota6.Text = s1p6.nota6 + " ";
            s1p6.nota7 = randomizer.Next(4, 8);nota7.Text = s1p6.nota7 + " ";
            s1p6.nota8 = randomizer.Next(5, 12);nota8.Text =s1p6.nota8 + " ";
            s1p6.nota9 = randomizer.Next(9, 12);nota9.Text =s1p6.nota9 + " ";
            s1p6.nota10 = randomizer.Next(2, 4); nota10.Text =s1p6.nota10 + " ";
            S1P6.Text = "6. La un test de matematică elevii unei clase au obținut note conform tabelului alăturat. Media aritmetică a clasei este:";
            double numitor = s1p6.nota4 + s1p6.nota5 + s1p6.nota6 + s1p6.nota7 + s1p6.nota8 + s1p6.nota9 + s1p6.nota10;
            double numarator = 4 * s1p6.nota4 + 5 * s1p6.nota5 + 6 * s1p6.nota6 + 7 * s1p6.nota7 + 8 * s1p6.nota8 + 9 * s1p6.nota9 + 10 * s1p6.nota10;
            double rez = Math.Round((numarator / numitor), 2);
            key = randomizer.Next(1, 5);
            if (key == 1)
            {
                corecte[6] = 1 << 3;
                S1P6RA.Text = rez + " ";
                S1P6RB.Text = (rez-1) + " ";
                S1P6RC.Text = (int)rez + " ";
                S1P6RD.Text = (int)(rez-1) + " ";
            }
            else
          if (key == 2)
            {
                corecte[6] = 1 << 2;
                S1P6RB.Text = rez + " ";
                S1P6RA.Text = (int)rez + " ";
                S1P6RC.Text = (rez-1) + " ";
                S1P6RD.Text = (int)(rez-1) + " ";
            }
            else
          if (key == 3)
            {
                corecte[6] = 1 << 1;
                S1P6RC.Text = rez + " ";
                S1P6RB.Text = (int)(rez-1) + " ";
                S1P6RA.Text = (int)rez + " ";
                S1P6RD.Text = (rez-1) + " ";
            }
            else
          if (key == 4)
            {
                corecte[6] = 1;
                S1P6RD.Text = rez + " ";
                S1P6RB.Text = (rez-1) + " ";
                S1P6RC.Text = (int)(rez-1) + " ";
                S1P6RA.Text = (int)(rez) + " ";
            }
            cuvinte s2p1 = new cuvinte();
            s2p1.nr1 = 65;
            s2p1.nr2 = randomizer.Next(66, 70);
            s2p1.nr3 = randomizer.Next(70, 74);
            s2p1.nr4 = randomizer.Next(74, 80);
            s2p1.nr5 = randomizer.Next(80, 86);
            s2p1.nr6 = randomizer.Next(86, 91);
            nr = 1;
            if (s2p1.nr2 == 69) nr++;
            if (s2p1.nr3 == 73) nr++;
            if (s2p1.nr4 == 79) nr++;
            if (s2p1.nr5 == 85) nr++;
            sol = nr;
            for (int i = 1; i <= 7 - nr; i++) sol *= i;
            corecte[7] = sol;
            S2P1.Text = "1. Câte cuvinte de lungime maximă, conținând o singură vocală, se pot obține din literele: " + (char)s2p1.nr1 + "," + (char)s2p1.nr2 + "," + (char)s2p1.nr3 + "," + (char)s2p1.nr4 + "," + (char)s2p1.nr5 + "," + (char)s2p1.nr6 + "?";

            int pitagora = randomizer.Next(1, 11);
            S2P2.Text = "2. Fie triunghiul dreptunghic ABC, cu latura AB ipotenuză. Dacă AC=" + pitagora * 3 + "cm iar BC=" + pitagora * 4 + "cm, măsura înălțimii din C la AB, exprimată în milimetri, este?";
            corecte[8] = pitagora * 24;

            int AOB = randomizer.Next(10, 60);
            int BOC = randomizer.Next(10, 60);
            int COD = randomizer.Next(10, 60);
            corecte[9] = BOC;
            S2P3.Text = "3. Fie A,B,C,D 4 puncte coliniare și O un punct din afara dreptei AB. Dacă măsura unghiului AOC este de " + (AOB+BOC) + "°, a unghiului BOD de " + (BOC+COD) + "°, iar a unghiului AOD de " + (AOB+BOC+COD) + "°, care este măsura unghiului BOC?";

            AOB = 8 * randomizer.Next(3, 23);
            int COB = AOB / 4;
            corecte[11] = AOB * 3 / 8;
            S2P5.Text = "5. Pe C(O,r) se pun 4 puncte A,B,C și D unde C se află în interiorul arcului AB, iar D în afara acestuia. Dacă măsura lui AOB este de " + AOB + "°, iar măsura lui COB este de " + COB + "°, aflați care este măsura lui ADC.";
            int cub1 = randomizer.Next(2, 11);
            corecte[12] = randomizer.Next(2, 11);
            S2P6.Text = "6. Fie cubul ABCDA'B'C'D', cu muchia AB=" + cub1 * corecte[12] + "cm. Secționăm cubul în " + cub1 * cub1 * cub1 + " cubulețe de dimensiuni egale. Lungimea muchiei unui astfel de cubuleț, exprimată în centimetri, este?";

            int x = randomizer.Next(2, 10);
            int y = randomizer.Next(15, 26);
            corecte[10] = (2 * y + 6 * x) * 2 * x;
            S2P4.Text = "4. Fie trapezul isoscel ABCD, AB||CD și AB>CD. Dacă AB = " + (y + 6 * x) + " cm, CD = " + y + " cm și BC = " + (5 * x) + " cm, care este aria trapezului?";

            int b = randomizer.Next(1, 11);
            int c = randomizer.Next(1, 11);
            if ((b + c) % 2 != 0) c++;
            a = b + c;
            d = a * b;
            int inplus = 1;
            for (int i = 2; i <= d; i++)
            {
                nr = 0;
                while (d % i == 0) { d /= i;nr++; }
                if (nr % 2 != 0) inplus *= i;
            }
            corecteb[1] = a * b * c;
            if (randomizer.Next(1, 3) == 1)
            {
                S3P1.Text = "1. Fie numerele a,b,c întregi astfel încât a+b+c=" + (a + b + c) + " și media aritmetică a numerelor b și c este " + (b + c) / 2 + ", atunci: \n       a) Este suma numerelor b și c egală cu a?(Se completează cu A pentru adevărat și F pentru fals) \n       b) Știind în plus că media geometrică a numerelor a și " + inplus + "b este " + Math.Sqrt(a * b * inplus) + ", aflați produsul celor trei numere.";
                corectea[1] = 1;
            }
            else
            {
                S3P1.Text = "1. Fie numerele a,b,c întregi astfel încât a+b+c=" + (a + b + c) + " și media aritmetică a numerelor b și c este " + (b + c) / 2 + ", atunci: \n       a) Este dublul sumei numerelor b și c egal cu a?(Se completează cu A pentru adevărat și F pentru fals) \n       b) Știind în plus că media geometrică a numerelor a și " + inplus + "b este " + Math.Sqrt(a * b * inplus) + ", aflați produsul celor trei numere.";
                corectea[1] = 0;
            }
            a = randomizer.Next(2, 16);
            b = randomizer.Next(2, 16);
            corectea[2] = 2 * a * b;
            corecteb[2] = a * b;
            S3P2.Text = "2. Fie ecuația E(x)=(x-" + a + ")(2-" + b + ")+(x+" + a + ")(2+" + b + "). \n       a) Pentru x=0, rezolvați ecuația; \n       b) Aflați x, știind că E(x)-2x=0";

            y = randomizer.Next(2, 11);
            x = 2 * y;
            S3P3.Text = "3. Se dau două numere reale a și b, astfel încât a+b=" + x + " și ab=" + y + ". \n       a) Să se calculeze a*a+b*b. \n       b) Să se calculeze (a/b)+(b/a).";
            corectea[3] = x * x - 2 * y;
            corecteb[3] = corectea[3] / y;

            x = randomizer.Next(2, 11);
            corectea[4] = 3 * x;
            corecteb[4] = 5 * x;
            S3P4.Text = "4. Fie triunghiul ABC isoscel, cu AB=AC. Fie D pe BC astfel încât BC=BD. Dacă AD=" + (4 * x) + "cm și perimetrul triunghiului este de " + (16 * x) + "cm, aflați: \n       a) Lungimea laturii BD; \n       b) Lungimea laturii AC.";

            corectea[5] = randomizer.Next(3, 21)*3;
            corecteb[5] = randomizer.Next(corectea[5] / 3, corectea[5] * 2 / 3 + 1) * corectea[5];
            S3P5.Text = "5. Fie trapezul dreptunghic ABCD, circumscris unui cerc de centru O și rază r. Dacă perimetrul trapezului este de " + (4 * corectea[5]) + " cm și înălțimea are " + (corecteb[5] / corectea[5]) + " cm, să se afle: \n       a) Lungimea liniei mijlocii; \n       b) Aria trapezului;";

            x = randomizer.Next(3,11);
            corectea6 = x * 2;
            corecteb6 = x * x * x * 3 * 173;
            S3P6.Text = "6. O piramidă SABCD are baza un patrulater în care unghiul A este egal cu unghiul D și cu dublul unghiului B, respectiv 120° și BC=2CD="+(2*x)+"*sqrt(6). Înălțimea piramidei cade la intersecția diagonalelor patrulaterului și două muchii laterale opuse sunt perpendiculare în S. Să se determine: \n       a) Lungimea înălțimii piramidei; \n       b) Volumul piramidei.\n       Notă: Se consideră sqrt(x)= radical din x; sqrt(3)=1,73, sqrt(2)=1,41. De asemenea, se scriu doar primele două zecimale ale rezultatelor.";


            cronometru.Text = "60 : 00";
            timer.Start();
        }
        int clockm = 60;
        int clocks = 0;
        private void test_Load(object sender, EventArgs e)
        {
        }

        private void time_Left_Click(object sender, EventArgs e)
        {

        }

        private void timer_Tick(object sender, EventArgs e)
        {
            if (clockm > 0 || clocks > 0)
            {
                if (clocks == 0)
                {
                    clockm = clockm - 1;
                    clocks = 59;
                }
                else
                    clocks = clocks - 1;
                if (clocks > 9)
                    cronometru.Text = clockm + " : " + clocks;
                else
                    cronometru.Text = clockm + " : 0" + clocks;
            }
            else
            {
                timer.Stop();
                cheat++;
                int x = 10;
                for (int i = 1; i <= 6; i++)
                    if (solutie[i] == corecte[i]) x += 5;
                string s2p1rc = S2P1R.Text;
                int s2p1rn = 0;
                for (int i = 0; i < s2p1rc.Length; i++)
                    if ((int)s2p1rc[i] >= '0' && (int)s2p1rc[i] <= '9')
                        s2p1rn = s2p1rn * 10 + s2p1rc[i] - '0';
                string s2p2rc = S2P2R.Text;
                int s2p2rn = 0;
                for (int i = 0; i < s2p2rc.Length; i++)
                    if ((int)s2p2rc[i] >= '0' && (int)s2p2rc[i] <= '9')
                        s2p2rn = s2p2rn * 10 + s2p2rc[i] - '0';
                string s2p6rc = S2P6R.Text;
                int s2p6rn = 0;
                for (int i = 0; i < s2p6rc.Length; i++)
                    if ((int)s2p6rc[i] >= '0' && (int)s2p6rc[i] <= '9')
                        s2p6rn = s2p6rn * 10 + s2p6rc[i] - '0';
                string s2p3rc = S2P3R.Text;
                int s2p3rn = 0;
                for (int i = 0; i < s2p3rc.Length; i++)
                    if ((int)s2p3rc[i] >= '0' && (int)s2p3rc[i] <= '9')
                        s2p3rn = s2p3rn * 10 + s2p3rc[i] - '0';
                string s2p4rc = S2P4R.Text;
                int s2p4rn = 0;
                for (int i = 0; i < s2p4rc.Length; i++)
                    if ((int)s2p4rc[i] >= '0' && (int)s2p4rc[i] <= '9')
                        s2p4rn = s2p4rn * 10 + s2p4rc[i] - '0';
                string s2p5rc = S2P5R.Text;
                int s2p5rn = 0;
                for (int i = 0; i < s2p5rc.Length; i++)
                    if ((int)s2p5rc[i] >= '0' && (int)s2p5rc[i] <= '9')
                        s2p5rn = s2p5rn * 10 + s2p5rc[i] - '0';
                if (s2p4rn == corecte[10]) x += 5;
                if (s2p5rn == corecte[11]) x += 5;
                if (s2p3rn == corecte[9]) x += 5;
                if (s2p6rn == corecte[12]) x += 5;
                if (s2p2rn == corecte[8]) x += 5;
                if (s2p1rn == corecte[7]) x += 5;

                string s3p1rca = S3P1RA.Text;
                int s3p1rna = -1;
                if (s3p1rca.Length > 0 && ((int)s3p1rca[0] == (int)'A' || (int)s3p1rca[0] == (int)'a'))
                    s3p1rna = 1;
                else if (s3p1rca.Length > 0 && ((int)s3p1rca[0] == (int)'F' || (int)s3p1rca[0] == (int)'f')) s3p1rna = 0;
                if (s3p1rna == corectea[1]) x += 2;
                string s3p1rcb = S3P1RB.Text;
                int s3p1rnb = 0;
                for (int i = 0; i < s3p1rcb.Length; i++)
                    if ((int)s3p1rcb[i] >= '0' && (int)s3p1rcb[i] <= '9')
                        s3p1rnb = s3p1rnb * 10 + s3p1rcb[i] - '0';
                if (s3p1rnb == corecteb[1]) x += 3;

                string s3p2rca = S3P2RA.Text;
                int s3p2rna = 0;
                for (int i = 0; i < s3p2rca.Length; i++)
                    if ((int)s3p2rca[i] >= '0' && (int)s3p2rca[i] <= '9')
                        s3p2rna = s3p2rna * 10 + s3p2rca[i] - '0';
                if (s3p2rna == corectea[2]) x += 2;
                string s3p2rcb = S3P2RB.Text;
                int s3p2rnb = 0;
                for (int i = 1; i < s3p2rcb.Length; i++)
                    if ((int)s3p2rcb[i] >= '0' && (int)s3p2rcb[i] <= '9')
                        s3p2rnb = s3p2rnb * 10 + s3p2rcb[i] - '0';
                if (s3p2rnb == corecteb[2]) x += 3;

                string s3p3rca = S3P3RA.Text;
                int s3p3rna = 0;
                for (int i = 0; i < s3p3rca.Length; i++)
                    if ((int)s3p3rca[i] >= '0' && (int)s3p3rca[i] <= '9')
                        s3p3rna = s3p3rna * 10 + s3p3rca[i] - '0';
                if (s3p3rna == corectea[3]) x += 2;
                string s3p3rcb = S3P3RB.Text;
                int s3p3rnb = 0;
                for (int i = 0; i < s3p3rcb.Length; i++)
                    if ((int)s3p3rcb[i] >= '0' && (int)s3p3rcb[i] <= '9')
                        s3p3rnb = s3p3rnb * 10 + s3p3rcb[i] - '0';
                if (s3p3rnb == corecteb[3]) x += 3;

                string s3p4rca = S3P4RA.Text;
                int s3p4rna = 0;
                for (int i = 0; i < s3p4rca.Length; i++)
                    if ((int)s3p4rca[i] >= '0' && (int)s3p4rca[i] <= '9')
                        s3p4rna = s3p4rna * 10 + s3p4rca[i] - '0';
                if (s3p4rna == corectea[4]) x += 3;
                string s3p4rcb = S3P4RB.Text;
                int s3p4rnb = 0;
                for (int i = 0; i < s3p4rcb.Length; i++)
                    if ((int)s3p4rcb[i] >= '0' && (int)s3p4rcb[i] <= '9')
                        s3p4rnb = s3p4rnb * 10 + s3p4rcb[i] - '0';
                if (s3p4rnb == corecteb[4]) x += 2;

                string s3p5rca = S3P5RA.Text;
                int s3p5rna = 0;
                for (int i = 0; i < s3p5rca.Length; i++)
                    if ((int)s3p5rca[i] >= '0' && (int)s3p5rca[i] <= '9')
                        s3p5rna = s3p5rna * 10 + s3p5rca[i] - '0';
                if (s3p5rna == corectea[5]) x += 3;
                string s3p5rcb = S3P5RB.Text;
                int s3p5rnb = 0;
                for (int i = 0; i < s3p5rcb.Length; i++)
                    if ((int)s3p5rcb[i] >= '0' && (int)s3p5rcb[i] <= '9')
                        s3p5rnb = s3p5rnb * 10 + s3p5rcb[i] - '0';
                if (s3p5rnb == corecteb[5]) x += 2;
                string s3p6rca = S3P6RA.Text;
                int s3p6rna = 0;
                for (int i = 0; i < s3p6rca.Length; i++)
                    if ((int)s3p6rca[i] >= '0' && (int)s3p6rca[i] <= '9')
                        s3p6rna = s3p6rna * 10 + s3p6rca[i] - '0';
                if (s3p6rna == corectea6) x += 3;
                string s3p6rcb = S3P6RB.Text;
                int s3p6rnb = 0;
                for (int i = 0; i < s3p6rcb.Length; i++)
                    if ((int)s3p6rcb[i] >= '0' && (int)s3p6rcb[i] <= '9')
                        s3p6rnb = s3p6rnb * 10 + s3p6rcb[i] - '0';
                if (s3p6rnb == 5190) s3p6rnb *= 100;
                if (s3p6rnb == corecteb6) x += 2;
                punctaj.Text = x + " / 100";
                cronometru.Text = "Timp scurs!";
            }
        }

        private void S1P1A_Click(object sender, EventArgs e)
        {
            solutie[1] = 1 << 3;
            S1P1A.BackColor = Color.Turquoise;
            S1P1B.BackColor = Color.Gainsboro;
            S1P1C.BackColor = Color.Gainsboro;
            S1P1D.BackColor = Color.Gainsboro;
        }

        private void S1P1B_Click(object sender, EventArgs e)
        {
            solutie[1] = 1 << 2;
            S1P1B.BackColor = Color.Turquoise;
            S1P1A.BackColor = Color.Gainsboro;
            S1P1C.BackColor = Color.Gainsboro;
            S1P1D.BackColor = Color.Gainsboro;
        }

        private void S1P1C_Click(object sender, EventArgs e)
        {
            solutie[1] = 1 << 1;
            S1P1C.BackColor = Color.Turquoise;
            S1P1B.BackColor = Color.Gainsboro;
            S1P1A.BackColor = Color.Gainsboro;
            S1P1D.BackColor = Color.Gainsboro;
        }

        private void S1P1D_Click(object sender, EventArgs e)
        {
            solutie[1] = 1;
            S1P1D.BackColor = Color.Turquoise;
            S1P1B.BackColor = Color.Gainsboro;
            S1P1C.BackColor = Color.Gainsboro;
            S1P1A.BackColor = Color.Gainsboro;
        }
        private void S1P2A_Click(object sender, EventArgs e)
        {
            solutie[2] = 1 << 3;
            S1P2A.BackColor = Color.Turquoise;
            S1P2B.BackColor = Color.Gainsboro;
            S1P2C.BackColor = Color.Gainsboro;
            S1P2D.BackColor = Color.Gainsboro;
        }

        private void S1P2B_Click(object sender, EventArgs e)
        {
            solutie[2] = 1 << 2;
            S1P2B.BackColor = Color.Turquoise;
            S1P2A.BackColor = Color.Gainsboro;
            S1P2C.BackColor = Color.Gainsboro;
            S1P2D.BackColor = Color.Gainsboro;
        }

        private void S1P2C_Click(object sender, EventArgs e)
        {
            solutie[2] = 1 << 1;
            S1P2C.BackColor = Color.Turquoise;
            S1P2B.BackColor = Color.Gainsboro;
            S1P2A.BackColor = Color.Gainsboro;
            S1P2D.BackColor = Color.Gainsboro;
        }

        private void S1P2D_Click(object sender, EventArgs e)
        {
            solutie[2] = 1;
            S1P2D.BackColor = Color.Turquoise;
            S1P2B.BackColor = Color.Gainsboro;
            S1P2C.BackColor = Color.Gainsboro;
            S1P2A.BackColor = Color.Gainsboro;
        }
        private void S1P3A_Click(object sender, EventArgs e)
        {
            solutie[3] = 1 << 3;
            S1P3A.BackColor = Color.Turquoise;
            S1P3B.BackColor = Color.Gainsboro;
            S1P3C.BackColor = Color.Gainsboro;
            S1P3D.BackColor = Color.Gainsboro;
        }

        private void S1P3B_Click(object sender, EventArgs e)
        {
            solutie[3] = 1 << 2;
            S1P3B.BackColor = Color.Turquoise;
            S1P3A.BackColor = Color.Gainsboro;
            S1P3C.BackColor = Color.Gainsboro;
            S1P3D.BackColor = Color.Gainsboro;
        }

        private void S1P3C_Click(object sender, EventArgs e)
        {
            solutie[3] = 1 << 1;
            S1P3C.BackColor = Color.Turquoise;
            S1P3B.BackColor = Color.Gainsboro;
            S1P3A.BackColor = Color.Gainsboro;
            S1P3D.BackColor = Color.Gainsboro;
        }

        private void S1P3D_Click(object sender, EventArgs e)
        {
            solutie[3] = 1;
            S1P3D.BackColor = Color.Turquoise;
            S1P3B.BackColor = Color.Gainsboro;
            S1P3C.BackColor = Color.Gainsboro;
            S1P3A.BackColor = Color.Gainsboro;
        }
        private void S1P4A_Click(object sender, EventArgs e)
        {
            solutie[4] = 1 << 3;
            S1P4A.BackColor = Color.Turquoise;
            S1P4B.BackColor = Color.Gainsboro;
            S1P4C.BackColor = Color.Gainsboro;
            S1P4D.BackColor = Color.Gainsboro;
        }

        private void S1P4B_Click(object sender, EventArgs e)
        {
            solutie[4] = 1 << 2;
            S1P4B.BackColor = Color.Turquoise;
            S1P4A.BackColor = Color.Gainsboro;
            S1P4C.BackColor = Color.Gainsboro;
            S1P4D.BackColor = Color.Gainsboro;
        }

        private void S1P4C_Click(object sender, EventArgs e)
        {
            solutie[4] = 1 << 1;
            S1P4C.BackColor = Color.Turquoise;
            S1P4B.BackColor = Color.Gainsboro;
            S1P4A.BackColor = Color.Gainsboro;
            S1P4D.BackColor = Color.Gainsboro;
        }

        private void S1P4D_Click(object sender, EventArgs e)
        {
            solutie[4] = 1;
            S1P4D.BackColor = Color.Turquoise;
            S1P4B.BackColor = Color.Gainsboro;
            S1P4C.BackColor = Color.Gainsboro;
            S1P4A.BackColor = Color.Gainsboro;
        }
        private void S1P5A_Click(object sender, EventArgs e)
        {
            solutie[5] = 1 << 3;
            S1P5A.BackColor = Color.Turquoise;
            S1P5B.BackColor = Color.Gainsboro;
            S1P5C.BackColor = Color.Gainsboro;
            S1P5D.BackColor = Color.Gainsboro;
        }

        private void S1P5B_Click(object sender, EventArgs e)
        {
            solutie[5] = 1 << 2;
            S1P5B.BackColor = Color.Turquoise;
            S1P5A.BackColor = Color.Gainsboro;
            S1P5C.BackColor = Color.Gainsboro;
            S1P5D.BackColor = Color.Gainsboro;
        }

        private void S1P5C_Click(object sender, EventArgs e)
        {
            solutie[5] = 1 << 1;
            S1P5C.BackColor = Color.Turquoise;
            S1P5B.BackColor = Color.Gainsboro;
            S1P5A.BackColor = Color.Gainsboro;
            S1P5D.BackColor = Color.Gainsboro;
        }

        private void S1P5D_Click(object sender, EventArgs e)
        {
            solutie[5] = 1;
            S1P5D.BackColor = Color.Turquoise;
            S1P5B.BackColor = Color.Gainsboro;
            S1P5C.BackColor = Color.Gainsboro;
            S1P5A.BackColor = Color.Gainsboro;
        }
        private void S1P6A_Click(object sender, EventArgs e)
        {
            solutie[6] = 1 << 3;
            S1P6A.BackColor = Color.Turquoise;
            S1P6B.BackColor = Color.Gainsboro;
            S1P6C.BackColor = Color.Gainsboro;
            S1P6D.BackColor = Color.Gainsboro;
        }

        private void S1P6B_Click(object sender, EventArgs e)
        {
            solutie[6] = 1 << 2;
            S1P6B.BackColor = Color.Turquoise;
            S1P6A.BackColor = Color.Gainsboro;
            S1P6C.BackColor = Color.Gainsboro;
            S1P6D.BackColor = Color.Gainsboro;
        }

        private void S1P6C_Click(object sender, EventArgs e)
        {
            solutie[6] = 1 << 1;
            S1P6C.BackColor = Color.Turquoise;
            S1P6B.BackColor = Color.Gainsboro;
            S1P6A.BackColor = Color.Gainsboro;
            S1P6D.BackColor = Color.Gainsboro;
        }

        private void S1P6D_Click(object sender, EventArgs e)
        {
            solutie[6] = 1;
            S1P6D.BackColor = Color.Turquoise;
            S1P6B.BackColor = Color.Gainsboro;
            S1P6C.BackColor = Color.Gainsboro;
            S1P6A.BackColor = Color.Gainsboro;
        }

        private void amterminat_Click(object sender, EventArgs e)
        {
            cheat++;
            if (cheat > 1)
                punctaj.Text = "Ai trișat!";
            else
            {
                int x = 10;
                for (int i = 1; i <= 6; i++)
                    if (solutie[i] == corecte[i]) x += 5;
                string s2p1rc = S2P1R.Text;
                int s2p1rn = 0;
                for (int i = 0; i < s2p1rc.Length; i++)
                    if ((int)s2p1rc[i] >= '0' && (int)s2p1rc[i] <= '9')
                        s2p1rn = s2p1rn * 10 + s2p1rc[i] - '0';
                string s2p2rc = S2P2R.Text;
                int s2p2rn = 0;
                for (int i = 0; i < s2p2rc.Length; i++)
                    if ((int)s2p2rc[i] >= '0' && (int)s2p2rc[i] <= '9')
                        s2p2rn = s2p2rn * 10 + s2p2rc[i] - '0';
                string s2p6rc = S2P6R.Text;
                int s2p6rn = 0;
                for (int i = 0; i < s2p6rc.Length; i++)
                    if ((int)s2p6rc[i] >= '0' && (int)s2p6rc[i] <= '9')
                        s2p6rn = s2p6rn * 10 + s2p6rc[i] - '0';
                string s2p3rc = S2P3R.Text;
                int s2p3rn = 0;
                for (int i = 0; i < s2p3rc.Length; i++)
                    if ((int)s2p3rc[i] >= '0' && (int)s2p3rc[i] <= '9')
                        s2p3rn = s2p3rn * 10 + s2p3rc[i] - '0';
                string s2p4rc = S2P4R.Text;
                int s2p4rn = 0;
                for (int i = 0; i < s2p4rc.Length; i++)
                    if ((int)s2p4rc[i] >= '0' && (int)s2p4rc[i] <= '9')
                        s2p4rn = s2p4rn * 10 + s2p4rc[i] - '0';
                string s2p5rc = S2P5R.Text;
                int s2p5rn = 0;
                for (int i = 0; i < s2p5rc.Length; i++)
                    if ((int)s2p5rc[i] >= '0' && (int)s2p5rc[i] <= '9')
                        s2p5rn = s2p5rn * 10 + s2p5rc[i] - '0';
                if (s2p4rn == corecte[10]) x += 5;
                if (s2p5rn == corecte[11]) x += 5;
                if (s2p3rn == corecte[9]) x += 5;
                if (s2p6rn == corecte[12]) x += 5;
                if (s2p2rn == corecte[8]) x += 5;
                if (s2p1rn == corecte[7]) x += 5;

                string s3p1rca = S3P1RA.Text;
                int s3p1rna = -1;
                if (s3p1rca.Length > 0 && ((int)s3p1rca[0] == (int)'A' || (int)s3p1rca[0] == (int)'a'))
                    s3p1rna = 1;
                else if (s3p1rca.Length > 0 && ((int)s3p1rca[0] == (int)'F' || (int)s3p1rca[0] == (int)'f')) s3p1rna = 0;
                if (s3p1rna == corectea[1]) x += 2;
                string s3p1rcb = S3P1RB.Text;
                int s3p1rnb = 0;
                for (int i = 0; i < s3p1rcb.Length; i++)
                    if ((int)s3p1rcb[i] >= '0' && (int)s3p1rcb[i] <= '9')
                        s3p1rnb = s3p1rnb * 10 + s3p1rcb[i] - '0';
                if (s3p1rnb == corecteb[1]) x += 3;

                string s3p2rca = S3P2RA.Text;
                int s3p2rna = 0;
                for (int i = 0; i < s3p2rca.Length; i++)
                    if ((int)s3p2rca[i] >= '0' && (int)s3p2rca[i] <= '9')
                        s3p2rna = s3p2rna * 10 + s3p2rca[i] - '0';
                if (s3p2rna == corectea[2]) x += 2;
                string s3p2rcb = S3P2RB.Text;
                int s3p2rnb = 0;
                for (int i = 1; i < s3p2rcb.Length; i++)
                    if ((int)s3p2rcb[i] >= '0' && (int)s3p2rcb[i] <= '9')
                        s3p2rnb = s3p2rnb * 10 + s3p2rcb[i] - '0';
                if (s3p2rnb == corecteb[2]) x += 3;

                string s3p3rca = S3P3RA.Text;
                int s3p3rna = 0;
                for (int i = 0; i < s3p3rca.Length; i++)
                    if ((int)s3p3rca[i] >= '0' && (int)s3p3rca[i] <= '9')
                        s3p3rna = s3p3rna * 10 + s3p3rca[i] - '0';
                if (s3p3rna == corectea[3]) x += 2;
                string s3p3rcb = S3P3RB.Text;
                int s3p3rnb = 0;
                for (int i = 0; i < s3p3rcb.Length; i++)
                    if ((int)s3p3rcb[i] >= '0' && (int)s3p3rcb[i] <= '9')
                        s3p3rnb = s3p3rnb * 10 + s3p3rcb[i] - '0';
                if (s3p3rnb == corecteb[3]) x += 3;

                string s3p4rca = S3P4RA.Text;
                int s3p4rna = 0;
                for (int i = 0; i < s3p4rca.Length; i++)
                    if ((int)s3p4rca[i] >= '0' && (int)s3p4rca[i] <= '9')
                        s3p4rna = s3p4rna * 10 + s3p4rca[i] - '0';
                if (s3p4rna == corectea[4]) x += 3;
                string s3p4rcb = S3P4RB.Text;
                int s3p4rnb = 0;
                for (int i = 0; i < s3p4rcb.Length; i++)
                    if ((int)s3p4rcb[i] >= '0' && (int)s3p4rcb[i] <= '9')
                        s3p4rnb = s3p4rnb * 10 + s3p4rcb[i] - '0';
                if (s3p4rnb == corecteb[4]) x += 2;

                string s3p5rca = S3P5RA.Text;
                int s3p5rna = 0;
                for (int i = 0; i < s3p5rca.Length; i++)
                    if ((int)s3p5rca[i] >= '0' && (int)s3p5rca[i] <= '9')
                        s3p5rna = s3p5rna * 10 + s3p5rca[i] - '0';
                if (s3p5rna == corectea[5]) x += 3;
                string s3p5rcb = S3P5RB.Text;
                int s3p5rnb = 0;
                for (int i = 0; i < s3p5rcb.Length; i++)
                    if ((int)s3p5rcb[i] >= '0' && (int)s3p5rcb[i] <= '9')
                        s3p5rnb = s3p5rnb * 10 + s3p5rcb[i] - '0';
                if (s3p5rnb == corecteb[5]) x += 2;
                string s3p6rca = S3P6RA.Text;
                int s3p6rna = 0;
                for (int i = 0; i < s3p6rca.Length; i++)
                    if ((int)s3p6rca[i] >= '0' && (int)s3p6rca[i] <= '9')
                        s3p6rna = s3p6rna * 10 + s3p6rca[i] - '0';
                if (s3p6rna == corectea6) x += 3;
                string s3p6rcb = S3P6RB.Text;
                int s3p6rnb = 0;
                for (int i = 0; i < s3p6rcb.Length; i++)
                    if ((int)s3p6rcb[i] >= '0' && (int)s3p6rcb[i] <= '9')
                        s3p6rnb = s3p6rnb * 10 + s3p6rcb[i] - '0';
                if (s3p6rnb == 5190) s3p6rnb *= 100;
                if (s3p6rnb == corecteb6) x += 2;
                punctaj.Text = x + " / 100";
            }

        }
    }
}
