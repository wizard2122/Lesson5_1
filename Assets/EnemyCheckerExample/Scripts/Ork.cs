using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class Ork : Character
{
    protected override void Affect(IEnumerable<Character> charaters)
    {
        Debug.Log($"���������� ���������� ���� �� {charaters.Count()} ����������");
    }
}
