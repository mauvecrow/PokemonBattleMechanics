using System.Reflection;

namespace PokemonBattleMechanics;
using static Type;
public static class Types
{
    public static List<Type> WeakAgainst(Type attacking)
    {
        List<Type> types = [];
        switch (attacking)
        {
            case Normal:
                // strong against nothing
                break;
            case Fire:
                types.AddRange([Grass, Ice, Bug]);
                break;
            case Water:
                types.AddRange(Fire, Ground, Rock);
                break;
            case Electric:
                types.AddRange(Water, Flying);
                break;
            case Grass:
                types.AddRange(Water, Rock, Ground);
                break;
            case Ice:
                types.AddRange(Grass, Ground, Flying, Dragon);
                break;
            case Fighting:
                types.AddRange(Normal, Ice, Rock, Dark, Steel);
                break;
            case Poison:
                types.AddRange(Grass, Fairy);
                break;
            case Ground:
                types.AddRange(Fire, Electric, Poison, Rock, Steel);
                break;
            case Flying:
                types.AddRange(Grass, Fighting, Bug);
                break;
            case Psychic:
                types.AddRange(Poison, Fighting);
                break;
            case Bug:
                types.AddRange(Grass, Psychic, Bug, Dark);
                break;
            case Rock:
                types.AddRange(Fire, Ice, Flying, Bug);
                break;
            case Ghost:
                types.AddRange(Psychic, Ghost);
                break;
            case Dragon:
                types.AddRange(Dragon);
                break;
            case Dark:
                types.AddRange(Psychic, Ghost);
                break;
            case Steel:
                types.AddRange(Ice, Rock, Fairy);
                break;
            case Fairy:
                types.AddRange(Fighting, Dragon, Dark);
                break;
            default:
                break;
        }

        return types;
    }
    
    public static List<Type> ResistantTo(Type attacking)
    {
        List<Type> types = [];
        switch (attacking)
        {
            case Normal:
                types.AddRange(Rock, Steel);
                break;
            case Fire:
                types.AddRange(Fire, Water, Rock, Dragon);
                break;
            case Water:
                types.AddRange(Water, Grass, Dragon);
                break;
            case Electric:
                types.AddRange(Electric, Grass, Dragon);
                break;
            case Grass:
                types.AddRange(Fire, Grass, Poison, Flying, Dragon, Steel);
                break;
            case Ice:
                types.AddRange(Fire, Water, Ice, Steel);
                break;
            case Fighting:
                types.AddRange(Poison, Flying, Psychic, Bug, Fairy);
                break;
            case Poison:
                types.AddRange(Poison, Ground, Rock, Ghost);
                break;
            case Ground:
                types.AddRange(Grass, Bug);
                break;
            case Flying:
                types.AddRange(Electric, Rock, Steel);
                break;
            case Psychic:
                types.AddRange(Psychic, Steel);
                break;
            case Bug:
                types.AddRange(Fire, Fighting, Poison, Flying, Ghost, Steel, Fairy);
                break;
            case Rock:
                types.AddRange(Fighting, Ground, Steel);
                break;
            case Ghost:
                types.AddRange(Dark);
                break;
            case Dragon:
                types.AddRange(Steel);
                break;
            case Dark:
                types.AddRange(Fighting, Dark, Fairy);
                break;
            case Steel:
                types.AddRange(Fire, Water, Electric, Steel);
                break;
            case Fairy:
                types.AddRange(Fire, Poison, Steel);
                break;
            default:
                break;
        }

        return types;
    }

    public static List<Type> ImmuneTo(Type attacking)
    {
        List<Type> types = [];
        switch(attacking)
        {
            case Normal:
            case Fighting:
                types.Add(Ghost);
                break;
            case Electric:
                types.Add(Ground);
                break;
            case Poison:
                types.Add(Steel);
                break;
            case Psychic:
                types.Add(Dark);
                break;
            case Ghost:
                types.Add(Normal);
                break;
            case Dragon:
                types.Add(Fairy);
                break;
            default:
                break;
        }
        return types;
    }
}