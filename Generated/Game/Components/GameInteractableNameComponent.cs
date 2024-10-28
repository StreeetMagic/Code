//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherInteractableName;

    public static Entitas.IMatcher<GameEntity> InteractableName {
        get {
            if (_matcherInteractableName == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.InteractableName);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherInteractableName = matcher;
            }

            return _matcherInteractableName;
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

    public Code.Gameplay.Features.InteractableName interactableName { get { return (Code.Gameplay.Features.InteractableName)GetComponent(GameComponentsLookup.InteractableName); } }
    public string InteractableName { get { return interactableName.Value; } }
    public bool hasInteractableName { get { return HasComponent(GameComponentsLookup.InteractableName); } }

    public GameEntity AddInteractableName(string newValue) {
        var index = GameComponentsLookup.InteractableName;
        var component = (Code.Gameplay.Features.InteractableName)CreateComponent(index, typeof(Code.Gameplay.Features.InteractableName));
        component.Value = newValue;
        AddComponent(index, component);
        return this;
    }

    public GameEntity ReplaceInteractableName(string newValue) {
        var index = GameComponentsLookup.InteractableName;
        var component = (Code.Gameplay.Features.InteractableName)CreateComponent(index, typeof(Code.Gameplay.Features.InteractableName));
        component.Value = newValue;
        ReplaceComponent(index, component);
        return this;
    }

    public GameEntity RemoveInteractableName() {
        RemoveComponent(GameComponentsLookup.InteractableName);
        return this;
    }
}