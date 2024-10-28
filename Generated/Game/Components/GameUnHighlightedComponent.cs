//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherUnHighlighted;

    public static Entitas.IMatcher<GameEntity> UnHighlighted {
        get {
            if (_matcherUnHighlighted == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.UnHighlighted);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherUnHighlighted = matcher;
            }

            return _matcherUnHighlighted;
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

    static readonly Code.Gameplay.Features.Highlight.UnHighlighted unHighlightedComponent = new Code.Gameplay.Features.Highlight.UnHighlighted();

    public bool isUnHighlighted {
        get { return HasComponent(GameComponentsLookup.UnHighlighted); }
        set {
            if (value != isUnHighlighted) {
                var index = GameComponentsLookup.UnHighlighted;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : unHighlightedComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}