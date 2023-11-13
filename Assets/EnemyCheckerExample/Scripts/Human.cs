using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Human : Character
{
    protected override void Affect(IEnumerable<Character> charaters)
    {
        Debug.Log($"Режу {charaters.Count()} персонажей");
    }
}
