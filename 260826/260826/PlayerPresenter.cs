public class PlayerPresenter
{
    private Player _player;
    private PlayerHealthUI _playerHealthUI;
    private ExpUI _expUi;

    public PlayerPresenter(Player player, PlayerHealthUI playerHealthUI, ExpUI expUI)
    {
        _player = player;
        _playerHealthUI = playerHealthUI;
        _expUi = expUI;
        BindChangeValueEvents();
    }

    public void BindChangeValueEvents()
    {
        _player.Health.Subscribe(_playerHealthUI);
        _player.Exp.Subscribe(_expUi);
    }
}