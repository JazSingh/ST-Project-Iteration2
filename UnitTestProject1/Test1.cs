﻿using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ST_Project;
using System.Collections.Generic;


namespace TestProject
{
    [TestClass]
    public class Test1
    {
        [TestMethod]
        public void Test_A()
        {
            // constraint: “The node-capacity rule is never breached.”
            // use MBC, with base: (full, yes, 2)

            /*
              Pseudo-code
              Log z = Load(...);
              z.init();
              while (z.hasNext()) 
              {
                GameState q = z.queryState() ;
                foreach Node n
                    Assert... n.capacity <= max_capacity
                z.next();
              }
             */

            A_1();
            A_2();
            A_3();
            A_4();
            A_5();
        }

        [TestMethod]
        public void A_1()
        {
            // (Full-Yes-2)
            Replayer z = new Replayer("1a-1.txt");
            z.Init();
            while (z.HasNext())
            {
                z.Step();
                Dungeon d = z.QueryState().GetDungeon();
                Node[] nodes = d.nodes;
                for (int t = 0; t < nodes.Length; t++)
                {
                    if (nodes[t] != null)
                    {
                        Stack<Pack> packs = nodes[t].getPacks();
                        int cap = 0;
                        foreach (Pack p in packs)
                            cap += p.GetNumMonsters();
                        Assert.IsTrue(cap <= nodes[t].GetCapacity());
                    }
                }
            } 
        }

        [TestMethod]
        public void A_2()
        {
            // (NotFull-Yes-2)
            Replayer z = new Replayer("1a-2.txt");
            z.Init();
            while (z.HasNext())
            {
                z.Step(); 
                Dungeon d = z.QueryState().GetDungeon();
                Node[] nodes = d.nodes;
                for (int t = 0; t < nodes.Length; t++)
                {
                    if (nodes[t] != null)
                    {
                        Stack<Pack> packs = nodes[t].getPacks();
                        int cap = 0;
                        foreach (Pack p in packs)
                            cap += p.GetNumMonsters();
                        Assert.IsTrue(cap <= nodes[t].GetCapacity());
                    }
                }
            }
        }

        [TestMethod]
        public void A_3()
        {
            // (Full-No-2)
            Replayer z = new Replayer("1a-3.txt");
            z.Init();
            while (z.HasNext())
            {
                z.Step();
                Dungeon d = z.QueryState().GetDungeon();
                Node[] nodes = d.nodes;
                for (int t = 0; t < nodes.Length; t++)
                {
                    if (nodes[t] != null)
                    {
                        Stack<Pack> packs = nodes[t].getPacks();
                        int cap = 0;
                        foreach (Pack p in packs)
                            cap += p.GetNumMonsters();
                        Assert.IsTrue(cap <= nodes[t].GetCapacity());
                    }
                }
            }
        }

        [TestMethod]
        public void A_4()
        {
            // (Full-Yes-3)
            Replayer z = new Replayer("1a-4.txt");
            z.Init();
            while (z.HasNext())
            {
                z.Step();
                Dungeon d = z.QueryState().GetDungeon();
                Node[] nodes = d.nodes;
                for (int t = 0; t < nodes.Length; t++)
                {
                    if (nodes[t] != null)
                    {
                        Stack<Pack> packs = nodes[t].getPacks();
                        int cap = 0;
                        foreach (Pack p in packs)
                            cap += p.GetNumMonsters();
                        Assert.IsTrue(cap <= nodes[t].GetCapacity());
                    }
                }
            }
        }

        [TestMethod]
        public void A_5()
        {
            // (Full-Yes-1)
            Replayer z = new Replayer("1a-5.txt");
            z.Init();
            while (z.HasNext())
            {
                z.Step();
                Dungeon d = z.QueryState().GetDungeon();
                Node[] nodes = d.nodes;
                for (int t = 0; t < nodes.Length; t++)
                {
                    if (nodes[t] != null)
                    {
                        Stack<Pack> packs = nodes[t].getPacks();
                        int cap = 0;
                        foreach (Pack p in packs)
                            cap += p.GetNumMonsters();
                        Assert.IsTrue(cap <= nodes[t].GetCapacity());
                    }
                }
            }
        }

        [TestMethod]
        public void Test_B()
        {
            // constraint: “The exit is always reachable from the player’s current node.”
            B_1();
            B_2();
        }

        [TestMethod]
        public void B_1()
        {
            // default movement
            Replayer z = new Replayer("1b-1.txt");
            z.Init();
            while (z.HasNext())
            {
                z.Step();
                GameState st = z.QueryState();
                Player p = st.GetPlayer();
                int pos = p.get_position();
                Dungeon d = st.GetDungeon();
                Stack<Node> path = d.ShortestPath(d.nodes[pos], d.nodes[d.nodes.Length-1]);
                Assert.IsTrue(path.Count > 0);
            }
        }

        [TestMethod]
        public void B_2()
        {
            // moving and causing explosion
            Replayer z = new Replayer("1b-2.txt");
            z.Init();
            while (z.HasNext())
            {
                z.Step();
                GameState st = z.QueryState();
                Player p = st.GetPlayer();
                int pos = p.get_position();
                Dungeon d = st.GetDungeon();
                Stack<Node> path = d.ShortestPath(d.nodes[pos], d.nodes[d.nodes.Length - 1]);
                Assert.IsTrue(path.Count > 0);
            }
        }

        [TestMethod]
        void Test_C()
        {
            // constraint: “Dropping healing potions never breaks the HP-restriction rule.”
        }
    }
}
