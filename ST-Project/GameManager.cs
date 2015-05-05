﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ST_Project
{

    public class GameManager
    {
        public GameState state;
        public Gamescherm gs;
        public Hoofdscherm hs;

        public GameManager()
        {
            Hoofdscherm hs = new Hoofdscherm(this);
            hs.Show();
        }

        //Methods called from View
        public void PlayerMoved(int newNode)
        {
            int i = state.GetPlayer().get_position();
            bool buur = false;

            if (i != newNode)
            {
                int[] buren = state.GetDungeon().nodes[i].getadj();
                for (int s = 0; s < buren.Length; s++)
                {
                    if (buren[s] == newNode)
                        buur = true;
                }

                if (buur)
                {
                    state.SetPosition(newNode);
                }
            }
        }

        //Hoofdscherm diff select
        public void DiffSelectNotify(int diff)
        {
            state = new GameState(diff);
            gs = new Gamescherm(diff, this);
            gs.Show();
            gs.Invalidate();
        }

        //Convience methods
        public Dungeon GetDungeon()
        {
            return state.GetDungeon();
        }

        public GameState GetState()
        {
            return state;
        }

        public Player GetPlayer()
        {
            return state.GetPlayer();
        }


    }
}
