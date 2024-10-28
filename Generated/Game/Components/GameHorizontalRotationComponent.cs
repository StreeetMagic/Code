//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherHorizontalRotation;

    public static Entitas.IMatcher<GameEntity> HorizontalRotation {
        get {
            if (_matcherHorizontalRotation == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.HorizontalRotation);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherHorizontalRotation = matcher;
            }

            return _matcherHorizontalRotation;
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

    public Code.Gameplay.Features.HorizontalRotation horizontalRotation { get { return (Code.Gameplay.Features.HorizontalRotation)GetComponent(GameComponentsLookup.HorizontalRotation); } }
    public float HorizontalRotation { get { return horizontalRotation.Value; } }
    public bool hasHorizontalRotation { get { return HasComponent(GameComponentsLookup.HorizontalRotation); } }

    public GameEntity AddHorizontalRotation(float newValue) {
        var index = GameComponentsLookup.HorizontalRotation;
        var component = (Code.Gameplay.Features.HorizontalRotation)CreateComponent(index, typeof(Code.Gameplay.Features.HorizontalRotation));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceHorizontalRotation(float newValue) {
        var index = GameComponentsLookup.HorizontalRotation;
        var component = (Code.Gameplay.Features.HorizontalRotation)CreateComponent(index, typeof(Code.Gameplay.Features.HorizontalRotation));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveHorizontalRotation() {
        RemoveComponent(GameComponentsLookup.HorizontalRotation);
        return this;
    }
}