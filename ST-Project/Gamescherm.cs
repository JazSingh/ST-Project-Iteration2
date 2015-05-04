﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ST_Project
{
    public partial class Gamescherm : Form
    {
        GameState game;

        public Gamescherm(int i)
        {
            InitializeComponent();
            game = new GameState(i);
            Paint += teken;
            this.DoubleBuffered = true;
        }

        public void teken(object sender, PaintEventArgs e)
        {
            Dictionary<int, Tuple<int, int>> locations = new Dictionary<int, Tuple<int, int>>();
            Graphics gr = e.Graphics;

            int x = 100;
            int y = 100;
            int h = 30;
            int w = 30;
            int x_dist = 0;
            switch(game.GetDungeon().difficulty)
            {
                case 5: { x_dist = 420 - (60 * (game.GetDungeon().difficulty - 1)); break; }
                default: { x_dist = 420 - (60 * (game.GetDungeon().difficulty)); break; }
            }
            int y_dist = 80;

            Node u = game.GetDungeon().nodes[0];
            Node v = game.GetDungeon().nodes[game.GetDungeon().nodes.Length - 1];
            Stack<Node> pad = game.GetDungeon().ShortestPath(u, v);

            Font drawFont = new Font("Arial", 16);

            ///////////// draw Dungeon, based on partitions

            // calc node-positions 
            // WARNING: 
            // DON'T LOOK AT THIS CODE, IT'S PURE MAGIC
            // ONLY THE WRITER KNOWS WHAT IT MEANS...
            for (int t = 0; t < game.GetDungeon().nodes.Length; t += game.GetDungeon().interval)
            {
                if (game.GetDungeon().nodes[t] != null)
                {
                    if (t % game.GetDungeon().interval == 0)
                    {
                        locations.Add(t, new Tuple<int, int>(x+(int)(0.5*w), y+(int)(0.5*h)));
                        int xx = x;
                        x += x_dist;
                        int buurtje = 1;
                        for (int z = t + 1; (z < game.GetDungeon().nodes.Length && z < t + game.GetDungeon().interval); z++)
                        {
                            if (game.GetDungeon().nodes[z] != null)
                            {
                                int my_x = 0;
                                int my_y = 0;
                                Brush c = Brushes.White;
                                switch (buurtje) // decides location of node
                                {
                                    case 1:
                                        {
                                            my_x = xx + (int)(0.25 * x_dist);
                                            my_y = y - y_dist;
                                            c = Brushes.Green;
                                            break;
                                        }
                                    case 2:
                                        {
                                            my_x = xx + (int)(0.25 * x_dist);
                                            my_y = y + y_dist;
                                            c = Brushes.Orange;
                                            break;
                                        }
                                    case 3:
                                        {
                                            my_x = xx + (int)(0.75 * x_dist);
                                            my_y = y - y_dist;
                                            c = Brushes.Red;
                                            break;
                                        }
                                    case 4:
                                        {
                                            my_x = xx + (int)(0.75 * x_dist);
                                            my_y = y + y_dist;
                                            c = Brushes.Purple;
                                            break;
                                        }
                                    case 5:
                                        {
                                            my_x = xx + (int)(0.50 * x_dist);
                                            my_y = y + y_dist*2;
                                            c = Brushes.Pink;
                                            break;
                                        }
                                    default: { Console.WriteLine("WTF!"); break; }
                                }

                                locations.Add(z, new Tuple<int, int>(my_x + (int)+(0.5 * w), my_y + (int)(0.5 * h)));
                                buurtje++;
                            }
                        }
                    }
                }
            }

            // draw Edges
            foreach (KeyValuePair<int, Tuple<int, int>> k in locations)
            {
                int key = k.Key;
                int x_pos = k.Value.Item1+(int)(0.5*w);
                int y_pos = k.Value.Item2+(int)(0.5*h);

                for (int t = 0; t < game.GetDungeon().nodes[key].adj.Length; t++)
                {
                    int buur = game.GetDungeon().nodes[key].adj[t];

                    if (game.GetDungeon().nodes[key].adj[t] > key)
                    {
                        int x_end = locations[buur].Item1 + (int)(0.5 * w);
                        int y_end = locations[buur].Item2 + (int)(0.5 * h);

                        gr.DrawLine(Pens.Black, x_pos, y_pos, x_end, y_end);
                    }
                }

                // draw node
                Brush color = Brushes.White;
                if (k.Key == 0)
                    color = Brushes.Green;              // color of start-node
                else if (k.Key != 0 && k.Key % game.GetDungeon().interval == 0)
                    color = Brushes.Orange;             // color of Bridge
                else if (k.Key == game.GetDungeon().nodes.Length - 1)
                    color = Brushes.Red;                // color of end-node

                gr.FillEllipse(color, k.Value.Item1, k.Value.Item2, w, h);
                gr.DrawString(k.Key.ToString(), drawFont, Brushes.Black, k.Value.Item1, k.Value.Item2);
            }

            Invalidate();
        }

        private void Gamescherm_Load(object sender, EventArgs e)
        {

        }
    }
}

