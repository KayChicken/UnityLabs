using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClassGirl : MonoBehaviour
{

    public MyLoveBuilder girlBuilder = new MyLoveBuilder();
    public Girl girl;

    public class Girl
    {

        public bool beautiful;
        public bool smart;
        public bool young;
        public bool rich;
        public bool charismatic;
        public bool nervous;
        public bool purposeful;
        public bool canCook;
        public bool talkative;
        public bool programmer;
        public bool gamer;

        public Girl(MyLoveBuilder girlBuilder)
        {
            beautiful = girlBuilder.beautiful;
            smart = girlBuilder.smart;
            young = girlBuilder.young;
            rich = girlBuilder.rich;
            charismatic = girlBuilder.charismatic;
            nervous = girlBuilder.nervous;
            purposeful = girlBuilder.purposeful;
            canCook = girlBuilder.canCook;
            talkative = girlBuilder.talkative;
            programmer = girlBuilder.programmer;
            gamer = girlBuilder.gamer;
        }
    }


    public class MyLoveBuilder
    {
        public bool beautiful;
        public bool smart;
        public bool young;
        public bool rich;
        public bool charismatic;
        public bool nervous;
        public bool purposeful;
        public bool canCook;
        public bool talkative;
        public bool programmer;
        public bool gamer;

        public MyLoveBuilder Beautiful(bool beautiful)
        {
            this.beautiful = beautiful;
            return this;
            
        }

        public MyLoveBuilder Smart(bool smart)
        {
            this.smart = smart;
            return this;

        }

        public MyLoveBuilder Young(bool young)
        {
            this.young = young;
            return this;

        }

        public MyLoveBuilder Rich(bool rich)
        {
            this.rich = rich;
            return this;

        }

        public MyLoveBuilder Charismatic(bool charismatic)
        {
            this.charismatic = charismatic;
            return this;

        }

        public MyLoveBuilder Nervous(bool nervous)
        {
            this.nervous = nervous;
            return this;

        }

       

        public MyLoveBuilder Purposeful(bool purposeful)
        {
            this.purposeful = purposeful;
            return this;

        }

        public MyLoveBuilder CanCook(bool canCook)
        {
            this.canCook = canCook;
            return this;

        }

        public MyLoveBuilder Talkative(bool talkative)
        {
            this.talkative = talkative;
            return this;

        }

        public MyLoveBuilder Programmer(bool programmer)
        {
            this.programmer = programmer;
            return this;

        }

        public MyLoveBuilder Gamer(bool gamer)
        {
            this.gamer = gamer;
            return this;

        }


        public Girl Build()
        {
            return new Girl(this);
        }


    }

   


    public void SetBeautiful(bool active)
    {
        girlBuilder.Beautiful(active);
    }

    public void SetSmart(bool active)
    {
        girlBuilder.Smart(active);
    }

    public void SetYoung(bool active)
    {
        girlBuilder.Young(active);
    }

    public void SetRich(bool active)
    {
        girlBuilder.Rich(active);
    }

    public void SetCharismatic(bool active)
    {
        girlBuilder.Charismatic(active);
    }

    public void SetNervous(bool active)
    {
        girlBuilder.Nervous(active);
    }

    public void SetPurposeful(bool active)
    {
        girlBuilder.Purposeful(active);
    }

    public void SetCanCook(bool active)
    {
        girlBuilder.CanCook(active);
    }

    public void SetTalkative(bool active)
    {
        girlBuilder.Talkative(active);
    }

    public void SetProgrammer(bool active)
    {
        girlBuilder.Programmer(active);
    }

    public void SetGamer(bool active)
    {
        girlBuilder.Gamer(active);
    }



    public void Build()
    {
        girl = girlBuilder.Build();
        GameObject.Find("ShowStatsController").GetComponent<StatsController>().girl = girl;
        
    }









}
