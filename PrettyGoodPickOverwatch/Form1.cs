using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrettyGoodPickOverwatch
{
    public partial class mainForm : Form
    {
        static int healers;
        static int tanks;
        static int damageDealers;
        static int totalCount;

        public bool blockButtons;

        public bool anaFlag;
        public bool angelFlag;
        public bool znecFlag;
        public bool junkratFlag;
        public bool deathfistFlag;
        public bool bastionFlag;
        public bool mayFlag;
        public bool widowFlag;
        public bool simmetraFlag;
        public bool soldierFlag;
        public bool sombraFlag;
        public bool thorbyornFlag;
        public bool tracerFlag;
        public bool farraFlag;
        public bool hanzoFlag;
        public bool makkriFlag;
        public bool ashFlag;
        public bool ganjiFlag;
        public bool zaryaFlag;
        public bool orisaFlag;
        public bool ryanhardFlag;
        public bool winstonFlag;
        public bool turboborrowFlag;
        public bool taranFlag;
        public bool dvaFlag;
        public bool batistFlag;
        public bool brigittaFlag;
        public bool dzeniataFlag;
        public bool lucioFlag;
        public bool moyraFlag;

        public mainForm()
        {
            InitializeComponent();
        }

        private void AnaPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\Ana\Ana";
            healerMethod(AnaPic, anaFlag, path);
            anaFlag = !anaFlag;
        }

        private void AngelPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\Angel\Angel";
            healerMethod(AngelPic, angelFlag, path);
            angelFlag = !angelFlag;
        }

        private void ZnecPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\Znec\Znec";
            damageDealerMethod(ZnecPic, znecFlag, path);
            znecFlag = !znecFlag;
        }

        private void JunkratPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\Junkrat\Junkrat";
            damageDealerMethod(JunkratPic, junkratFlag, path);
            junkratFlag = !junkratFlag;
        }

        private void DeathFistPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\deathFist\Deathfist";
            damageDealerMethod(DeathFistPic, deathfistFlag, path);
            deathfistFlag = !deathfistFlag;
        }

        private void BastionPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\Bastion\Bastion";
            damageDealerMethod(BastionPic, bastionFlag, path);
            bastionFlag = !bastionFlag;
        }

        private void MayPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\May\May";
            damageDealerMethod(MayPic, mayFlag, path);
            mayFlag = !mayFlag;
        }

        private void WidowPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\Widow\Widow";
            damageDealerMethod(WidowPic, widowFlag, path);
            widowFlag = !widowFlag;
        }

        private void SimmetraPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\Simmetra\Simmetra";
            damageDealerMethod(SimmetraPic, simmetraFlag, path);
            simmetraFlag = !simmetraFlag;
        }

        private void SoldierPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\Soldier\Soldier";
            damageDealerMethod(SoldierPic, soldierFlag, path);
            soldierFlag = !soldierFlag;
        }

        private void SombraPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\Sombra\Sombra";
            damageDealerMethod(SombraPic, sombraFlag, path);
            sombraFlag = !sombraFlag;
        }

        private void ThorbyornPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\Thorbyorn\Thorbyorn";
            damageDealerMethod(ThorbyornPic, thorbyornFlag, path);
            thorbyornFlag = !thorbyornFlag;
        }

        private void TracerPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\Tracer\Tracer";
            damageDealerMethod(TracerPic, tracerFlag, path);
            tracerFlag = !tracerFlag;
        }

        private void FarraPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\Farra\Farra";
            damageDealerMethod(FarraPic, farraFlag, path);
            farraFlag = !farraFlag;
        }

        private void HanzoPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\Hanzo\Hanzo";
            damageDealerMethod(HanzoPic, hanzoFlag, path);
            hanzoFlag = !hanzoFlag;
        }

        private void MakkriPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\Makkri\Makkri";
            damageDealerMethod(MakkriPic, makkriFlag, path);
            makkriFlag = !makkriFlag;
        }

        private void AshPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\Ash\Ash";
            damageDealerMethod(AshPic, ashFlag, path);
            ashFlag = !ashFlag;
        }

        private void GanjiPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\Ganji\Ganji";
            damageDealerMethod(GanjiPic, ganjiFlag, path);
            ganjiFlag = !ganjiFlag;
        }

        private void zaryaPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\Zarya\Zarya";
            tankMethod(zaryaPic, zaryaFlag, path);
            zaryaFlag = !zaryaFlag;
        }

        private void orisaPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\Orisa\orisa";
            tankMethod(orisaPic, orisaFlag, path);
            orisaFlag = !orisaFlag;
        }

        private void rayanhardPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\rayanhard\rayanhard";
            tankMethod(rayanhardPic, ryanhardFlag, path);
            ryanhardFlag = !ryanhardFlag;
        }

        private void winstonPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\winston\winston";
            tankMethod(winstonPic, winstonFlag, path);
            winstonFlag = !winstonFlag;
        }

        private void turboborrowPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\turboborrow\turboborrow";
            tankMethod(turboborrowPic, turboborrowFlag, path);
            turboborrowFlag = !turboborrowFlag;
        }

        private void taranPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\taran\taran";
            tankMethod(taranPic, taranFlag, path);
            taranFlag = !taranFlag;
        }

        private void dvaPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\d.va\Dva";
            tankMethod(dvaPic, dvaFlag, path);
            dvaFlag = !dvaFlag;
        }

        private void BatistPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\Batist\Batist";
            healerMethod(BatistPic, batistFlag, path);
            batistFlag = !batistFlag;
        }

        private void BrigittaPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\Brigitta\Brigitta";
            healerMethod(BrigittaPic, brigittaFlag, path);
            brigittaFlag = !brigittaFlag;
        }

        private void DzeniataPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\Dzeniata\Dzeniata";
            healerMethod(DzeniataPic, dzeniataFlag, path);
            dzeniataFlag = !dzeniataFlag;
        }

        private void LucioPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\Lucio\Lucio";
            healerMethod(LucioPic, lucioFlag, path);
            lucioFlag = !lucioFlag;
        }

        private void MoyraPic_Click(object sender, EventArgs e)
        {
            string path = @"images\Characters\Moyra\Moyra";
            healerMethod(MoyraPic, moyraFlag, path);
            moyraFlag = !moyraFlag;
        }

        public void healerMethod(PictureBox box, bool flag, string path)
        {
            if (!blockButtons)
            {
                if (totalCount == 5)
                {
                    if (!flag)
                    {
                        path += @"Prior.jpg";
                        box.Image = Image.FromFile(path);
                    }
                }
                else
                {

                    if (flag)
                    {
                        path += @"Main.jpg";
                        box.Image = Image.FromFile(path);
                        healers--;
                        totalCount--;
                    }
                    else
                    {

                        {
                            if (totalCount < 6 && totalCount >= 0)
                            {
                                healers++;
                                totalCount++;
                                if (totalCount == 5)
                                {
                                    showPick();
                                }
                                path += @"Picked.jpg";
                                box.Image = Image.FromFile(path);

                            }
                        }
                    }               
                }
            }
            
        }

        public void damageDealerMethod(PictureBox box, bool flag, string path)
        {
            if (!blockButtons)
            {
                if (totalCount == 5)
                {
                    if (!flag)
                    {
                        path += @"Prior.jpg";
                        box.Image = Image.FromFile(path);
                    }
                }
                else
                {

                    if (!flag)
                    {

                        if (totalCount < 6 && totalCount >= 0)
                        {
                            damageDealers++;
                            totalCount++;
                            if (totalCount == 5)
                            {
                                showPick();
                            }
                            path += @"Picked.jpg";
                            box.Image = Image.FromFile(path);
                        }
                    }

                    else
                    {
                        path += @"Main.jpg";
                        box.Image = Image.FromFile(path);
                        damageDealers--;
                        totalCount--;
                    }
                   
                }
            }
            
        }

        public void tankMethod(PictureBox box, bool flag, string path)
        {
            if (!blockButtons)
            {
                if (totalCount == 5)
                {
                    if (!flag)
                    {
                        path += @"Prior.jpg";
                        box.Image = Image.FromFile(path);
                    }
                }
                else
                {

                    if (!flag)
                    {

                        if (totalCount < 6 && totalCount >= 0)
                        {
                            tanks++;
                            totalCount++;
                            if (totalCount == 5)
                            {
                                showPick();
                            }
                            path += @"Picked.jpg";
                            box.Image = Image.FromFile(path);
                        }
                    }

                    else
                    {
                        path += @"Main.jpg";
                        box.Image = Image.FromFile(path);
                        tanks--;
                        totalCount--;
                    }                    
                }
            }
           
        }

        public void showPick() {          
            if (tanks < 2)
            {
                dvaPic_Click(new object(), new EventArgs());
                rayanhardPic_Click(new object(), new EventArgs());
                orisaPic_Click(new object(), new EventArgs());
                zaryaPic_Click(new object(), new EventArgs());
                winstonPic_Click(new object(), new EventArgs());
                taranPic_Click(new object(), new EventArgs());
                turboborrowPic_Click(new object(), new EventArgs());
                if (healers < 2)
                {
                    yellowHealers();
                }
                if (damageDealers < 2) {
                    yellowDd();
                }
            }
            else
            {
                if (healers < 2)
                {
                    yellowHealers();
                    yellowDd();
                }
                else {
                    yellowDd();
                }
            }
            blockButtons = true;

        }

        public void yellowDd() {
            BastionPic_Click(new object(), new EventArgs());
            GanjiPic_Click(new object(), new EventArgs());
            ZnecPic_Click(new object(), new EventArgs());
            JunkratPic_Click(new object(), new EventArgs());
            DeathFistPic_Click(new object(), new EventArgs());
            MakkriPic_Click(new object(), new EventArgs());
            MayPic_Click(new object(), new EventArgs());
            WidowPic_Click(new object(), new EventArgs());
            SimmetraPic_Click(new object(), new EventArgs());
            SoldierPic_Click(new object(), new EventArgs());
            SombraPic_Click(new object(), new EventArgs());
            ThorbyornPic_Click(new object(), new EventArgs());
            TracerPic_Click(new object(), new EventArgs());
            FarraPic_Click(new object(), new EventArgs());
            HanzoPic_Click(new object(), new EventArgs());
            AshPic_Click(new object(), new EventArgs());
        }

        public void yellowHealers() {
            AnaPic_Click(new object(), new EventArgs());
            AngelPic_Click(new object(), new EventArgs());
            LucioPic_Click(new object(), new EventArgs());
            MoyraPic_Click(new object(), new EventArgs());
            DzeniataPic_Click(new object(), new EventArgs());
            BatistPic_Click(new object(), new EventArgs());
            BrigittaPic_Click(new object(), new EventArgs());
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            totalCount = 0;
            healers = 0;
            damageDealers = 0;
            tanks = 0;
            blockButtons = false;
            AnaPic.Image = Image.FromFile(@"images\Characters\Ana\AnaMain.jpg");
            AngelPic.Image = Image.FromFile(@"images\Characters\Angel\AngelMain.jpg");
            LucioPic.Image = Image.FromFile(@"images\Characters\Lucio\LucioMain.jpg");
            MoyraPic.Image = Image.FromFile(@"images\Characters\Moyra\MoyraMain.jpg");
            DzeniataPic.Image = Image.FromFile(@"images\Characters\Dzeniata\DzeniataMain.jpg");
            BatistPic.Image = Image.FromFile(@"images\Characters\Batist\BatistMain.jpg");
            BrigittaPic.Image = Image.FromFile(@"images\Characters\Brigitta\BrigittaMain.jpg");
            BastionPic.Image = Image.FromFile(@"images\Characters\Bastion\BastionMain.jpg");
            GanjiPic.Image = Image.FromFile(@"images\Characters\Ganji\GanjiMain.jpg");
            ZnecPic.Image = Image.FromFile(@"images\Characters\Znec\ZnecMain.jpg");
            DeathFistPic.Image = Image.FromFile(@"images\Characters\DeathFist\DeathFistMain.jpg");
            MakkriPic.Image = Image.FromFile(@"images\Characters\Makkri\MakkriMain.jpg");
            MayPic.Image = Image.FromFile(@"images\Characters\May\MayMain.jpg");
            WidowPic.Image = Image.FromFile(@"images\Characters\Widow\WidowMain.jpg");
            SimmetraPic.Image = Image.FromFile(@"images\Characters\Simmetra\SimmetraMain.jpg");
            SoldierPic.Image = Image.FromFile(@"images\Characters\Soldier\SoldierMain.jpg");
            SombraPic.Image = Image.FromFile(@"images\Characters\Sombra\SombraMain.jpg");
            ThorbyornPic.Image = Image.FromFile(@"images\Characters\Thorbyorn\ThorbyornMain.jpg");
            TracerPic.Image = Image.FromFile(@"images\Characters\Tracer\TracerMain.jpg");
            FarraPic.Image = Image.FromFile(@"images\Characters\Farra\FarraMain.jpg");
            HanzoPic.Image = Image.FromFile(@"images\Characters\Hanzo\HanzoMain.jpg");
            AshPic.Image = Image.FromFile(@"images\Characters\Ash\AshMain.jpg");
            dvaPic.Image = Image.FromFile(@"images\Characters\d.va\dvaMain.jpg");
            rayanhardPic.Image = Image.FromFile(@"images\Characters\rayanhard\rayanhardMain.jpg");
            orisaPic.Image = Image.FromFile(@"images\Characters\Orisa\OrisaMain.jpg");
            zaryaPic.Image = Image.FromFile(@"images\Characters\zarya\zaryaMain.jpg");
            winstonPic.Image = Image.FromFile(@"images\Characters\winston\winstonMain.jpg");
            taranPic.Image = Image.FromFile(@"images\Characters\taran\taranMain.jpg");
            turboborrowPic.Image = Image.FromFile(@"images\Characters\turboborrow\turboborrowMain.jpg");
            JunkratPic.Image = Image.FromFile(@"images\Characters\junkrat\junkratMain.jpg");
            anaFlag = false;
            angelFlag = false;
            znecFlag = false;
            junkratFlag = false;
            deathfistFlag = false;
            bastionFlag = false;
            mayFlag = false;
            widowFlag = false;
            simmetraFlag = false;
            soldierFlag = false;
            sombraFlag = false;
            thorbyornFlag = false;
            tracerFlag = false;
            farraFlag = false;
            hanzoFlag = false;
            makkriFlag = false;
            ashFlag = false;
            ganjiFlag = false;
            zaryaFlag = false;
            orisaFlag = false;
            ryanhardFlag = false;
            winstonFlag = false;
            turboborrowFlag = false;
            taranFlag = false;
            dvaFlag = false;
            batistFlag = false;
            brigittaFlag = false;
            dzeniataFlag = false;
            lucioFlag = false;
            moyraFlag = false;
        }
    }    
}
