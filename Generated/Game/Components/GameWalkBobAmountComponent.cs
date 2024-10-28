//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherWalkBobAmount;

    public static Entitas.IMatcher<GameEntity> WalkBobAmount {
        get {
            if (_matcherWalkBobAmount == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.WalkBobAmount);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherWalkBobAmount = matcher;
            }

            return _matcherWalkBobAmount;
        }
    }
}

//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentEntityApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public partial class GameEntity {

    public Code.Gameplay.Features.Player.WalkBobAmount walkBobAmount { get { return (Code.Gameplay.Features.Player.WalkBobAmount)GetComponent(GameComponentsLookup.WalkBobAmount); } }
    public float WalkBobAmount { get { return walkBobAmount.Value; } }
    public bool hasWalkBobAmount { get { return HasComponent(GameComponentsLookup.WalkBobAmount); } }

    public GameEntity AddWalkBobAmount(float newValue) {
        var index = GameComponentsLookup.WalkBobAmount;
        var component = (Code.Gameplay.Features.Player.WalkBobAmount)CreateComponent(index, typeof(Code.Gameplay.Features.Player.WalkBobAmount));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceWalkBobAmount(float newValue) {
        var index = GameComponentsLookup.WalkBobAmount;
        var component = (Code.Gameplay.Features.Player.WalkBobAmount)CreateComponent(index, typeof(Code.Gameplay.Features.Player.WalkBobAmount));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveWalkBobAmount() {
        RemoveComponent(GameComponentsLookup.WalkBobAmount);
        return this;
    }
}