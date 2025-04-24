using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OOAPLab2_WithPattern
{
    public partial class Form1 : Form
    {
        public BaseHero firstHero;
        public BaseHero secondHero;
        public Form1()
        {
            InitializeComponent();
        }

        private BaseHero createHero()
        {
            BaseHero hero;

            if (comboBoxType.SelectedIndex == 0)
                hero = new RedHero();
            else
                hero = new GreenHero();

            if (checkBoxPower.Checked)
                hero.setSuperPower(true);
            if (checkBoxAgile.Checked)
                hero.setSuperAgile(true);
            if (checkBoxIntel.Checked)
                hero.setSuperIntel(true);

            return hero;
        }

        private void printAlive(BaseHero hero)
        {
            labelWon.Text = $"Побеждает герой: {hero.getDescription()}";

            if (hero.getDescription().Contains("Зелёный герой"))
                labelWon.ForeColor = Color.OliveDrab;
            else
                labelWon.ForeColor = Color.Firebrick;      
        }

        private string printInfo(BaseHero hero)
        {
            return $"Герой {hero.getDescription()}\r\n{hero.getStringChance()}" +
                $"\r\nИтоговый шанс на победу равен {hero.getChanceOfSurvival()}";
        }

        private void clearAll()
        {
            checkBoxPower.Checked = false;
            checkBoxAgile.Checked = false;
            checkBoxIntel.Checked = false;
            comboBoxType.SelectedItem = null;
            labelFirstHero.Text = "";
            labelSecondHero.Text = "";
            labelWon.Text = "";
        }

        private void fight()
        {
            if (firstHero.getChanceOfSurvival() > secondHero.getChanceOfSurvival())
                printAlive(firstHero);
            else if (secondHero.getChanceOfSurvival() > firstHero.getChanceOfSurvival())
                printAlive(secondHero);
            else
            {
                labelWon.Text = "Ничья";
                labelWon.ForeColor = System.Drawing.Color.RoyalBlue;
            }

            buttonAddHero.Enabled = false;
            buttonNewFight.Visible = true;
        }

        private void AddHero(object sender, EventArgs e)
        {
            if (firstHero == null)
            {
                firstHero = createHero();
                clearAll();
                buttonAddHero.Text = "Добавить героя и начать битву";
            }    
            else
            {
                secondHero = createHero();
                labelFirstHero.Text = printInfo(firstHero);
                labelSecondHero.Text = printInfo(secondHero);
                fight();
            }
                
        }
        private void createNewFight(object sender, EventArgs e)
        {
            buttonAddHero.Enabled = true;
            buttonAddHero.Text = "Добавить героя";
            buttonNewFight.Visible = false;
            firstHero = null;
            secondHero = null;
            clearAll();
        }
    }
}

public interface IHero 
{
    string getDescription();
    int getChanceOfSurvival();
    string getStringChance();
}

public class BaseHero : IHero
{
    private bool superPower;
    private bool superAgile;
    private bool superIntel;

    public bool hasSuperPower() => superPower;
    public bool hasSuperAgile() => superAgile;
    public bool hasSuperIntel() => superIntel;
    public void setSuperPower(bool _superPower)
    {
        superPower = _superPower;
    }
    public void setSuperAgile(bool _superAgile)
    {
        superAgile = _superAgile;
    }
    public void setSuperIntel(bool _superIntel)
    {
        superIntel = _superIntel;
    }
    public virtual string getDescription()
    {
        string description = "";

        if (superPower)
            description += " с супер силой";
        if (superAgile)
            description += " с супер ловкостью";
        if (superIntel)
            description += " с супер интеллектом";

        return description;
    }

    public virtual int getChanceOfSurvival()
    {
        int chanceOfSurvival = 0;

        if (superPower)
            chanceOfSurvival += 6;
        if (superAgile)
            chanceOfSurvival += 5;
        if (superIntel)
            chanceOfSurvival += 4;

        return chanceOfSurvival;
    }
    public virtual string getStringChance()
    {
        string chance = "";

        if (superPower)
            chance += "\r\nдоп. шанс от супер ловкости: 6";
        if (superAgile)
            chance += "\r\nдоп. шанс от супер ловкости: 5";
        if (superIntel)
            chance += "\r\nдоп. шанс от супер интеллекта: 4";

        return chance;
    }
}

public class GreenHero : BaseHero
{
    public override int getChanceOfSurvival()
    {
        return 50 + base.getChanceOfSurvival();
    }
    public override string getDescription()
    {
        return "Зелёный герой" + base.getDescription();
    }
    public override string getStringChance()
    {
        return "Базовый шанс победы: 50" + base.getStringChance();
    }
}

public class RedHero : BaseHero
{
    public override int getChanceOfSurvival()
    {
        return 52 + base.getChanceOfSurvival();
    }
    public override string getDescription()
    {
        return "Красный герой" + base.getDescription();
    }
    public override string getStringChance()
    {
        return "Базовый шанс победы: 52" + base.getStringChance();
    }
}