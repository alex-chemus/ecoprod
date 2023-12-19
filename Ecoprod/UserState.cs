using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecoprod;

enum Rank {
    Senior = 1,
    Middle = 2
}

internal class UserState
{
    private static UserState instance;

    public int id;

    public Rank rank;

    private UserState(int id, Rank rank)
    {
        this.id = id;
        this.rank = rank;
    }

    public static UserState getInstance() => instance;

    public static void createInstance(int id, Rank rank) 
    {
        instance = new UserState(id, rank);
    }
}
