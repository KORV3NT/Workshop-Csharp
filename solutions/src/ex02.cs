/*
** EPITECH PROJECT, 2024
** workshop_csharp
** File description:
** ex02
*/

using System;

class Player
{
    public Player(string username, int health, double xp)
    {
        this._username = username;
        this._health = health;
        this._xp = xp;
    }

    public string getUsername()
    {
        return _username;
    }

    public int getHealth()
    {
        return _health;
    }

    public double getXp()
    {
        return _xp;
    }

    private string _username;
    private int _health;
    private double _xp;
}

class Program
{
    static void Main()
    {
        Player player = new Player("Francis", 20, 10.0);

        Console.WriteLine("{0} has {1} hp and {2} xp.", player.getUsername(), player.getHealth(), player.getXp());
    }
}
