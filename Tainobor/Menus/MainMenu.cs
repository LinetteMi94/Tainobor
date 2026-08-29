using Tainobor.Characters;

namespace Tainobor.Menus;

public class MainMenu
{
    private static Player _player;
    
    public static void Show(Player player)
    {
        _player =  player;
    }
}