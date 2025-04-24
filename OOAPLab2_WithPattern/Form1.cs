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
        public IHero firstHero;
        public IHero secondHero;
        public Form1()
        {
            InitializeComponent();
        }

        private IHero createHero()
        {
            IHero hero;

            if (comboBoxType.SelectedIndex == 0)
                hero = new RedHero();
            else
                hero = new GreenHero();

            if (checkBoxPower.Checked)
                hero = new SuperPowerDecorator(hero);
            if (checkBoxAgile.Checked)
                hero = new SuperAgileDecorator(hero);
            if (checkBoxIntel.Checked)
                hero = new SuperIntelDecorator(hero);

            return hero;
        }

        private void printAlive(IHero hero)
        {
            labelWon.Text = $"Побеждает герой: {hero.getDescription()}";

            if (hero.getDescription().Contains("Зелёный герой"))
                labelWon.ForeColor = Color.OliveDrab;
            else
                labelWon.ForeColor = Color.Firebrick;      
        }

        private string printInfo(IHero hero)
        {
            return $"Герой {hero.getDescription()}\r\n{hero.getStringChance()}" +
                $"\r\nИтоговый шанс на победу равен: {hero.getChanceOfSurvival()}";
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

public class GreenHero : IHero
{
    public int getChanceOfSurvival()
    {
        return 50;
    }
    public string getDescription()
    {
        return "Зелёный герой";
    }
    public string getStringChance()
    {
        return "Базовый шанс победы: " + getChanceOfSurvival();
    }
}

public class RedHero : IHero
{
    public int getChanceOfSurvival()
    {
        return 52;
    }
    public string getDescription()
    {
        return "Красный герой";
    }

    public string getStringChance()
    {
        return "Базовый шанс победы: " + getChanceOfSurvival();
    }
}

public abstract class BaseHeroDecorator : IHero
{
    protected IHero _hero;

    public BaseHeroDecorator(IHero hero)
    {
        _hero = hero;
    }

    public virtual string getDescription()
    {
        return _hero.getDescription();
    }

    public virtual int getChanceOfSurvival()
    {
        return _hero.getChanceOfSurvival();
    }
    public virtual string getStringChance()
    {
        return _hero.getStringChance();
    }
}

public class SuperPowerDecorator : BaseHeroDecorator
{
    public SuperPowerDecorator(IHero hero) : base(hero) {}

    public override string getDescription()
    {
        return base.getDescription() + " с супер силой";
    }

    public override int getChanceOfSurvival()
    {
        return base.getChanceOfSurvival() + 6;
    }
    public override string getStringChance()
    {
        return base.getStringChance() + "\r\nдоп. шанс от супер силы: 6";
    }
}

public class SuperAgileDecorator : BaseHeroDecorator
{
    public SuperAgileDecorator(IHero hero) : base(hero) {}

    public override string getDescription()
    {
        return base.getDescription() + " с супер ловкостью";
    }

    public override int getChanceOfSurvival()
    {
        return base.getChanceOfSurvival() + 5;
    }
    public override string getStringChance()
    {
        return base.getStringChance() + "\r\nдоп. шанс от супер ловкости: 5";
    }
}

public class SuperIntelDecorator : BaseHeroDecorator
{
    public SuperIntelDecorator(IHero hero) : base(hero) { }

    public override string getDescription()
    {
        return base.getDescription() + " с супер интеллектом";
    }
    public override int getChanceOfSurvival()
    {
        return base.getChanceOfSurvival() + 4;
    }
    public override string getStringChance()
    {
        return base.getStringChance() + "\r\nдоп. шанс от супер интеллекта: 4";
    }
}