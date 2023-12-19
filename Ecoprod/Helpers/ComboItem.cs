using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecoprod.Helpers;

internal class ComboItem
{
    public int id;
    public string title;

    public ComboItem(int id, string title)
    {
        this.id = id;
        this.title = title;
    }

    public override string ToString() => title;

    public int getId() => this.id;
}

