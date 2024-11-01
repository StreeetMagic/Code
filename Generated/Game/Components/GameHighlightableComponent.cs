//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by Entitas.CodeGeneration.Plugins.ComponentMatcherApiGenerator.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
public sealed partial class GameMatcher {

    static Entitas.IMatcher<GameEntity> _matcherHighlightable;

    public static Entitas.IMatcher<GameEntity> Highlightable {
        get {
            if (_matcherHighlightable == null) {
                var matcher = (Entitas.Matcher<GameEntity>)Entitas.Matcher<GameEntity>.AllOf(GameComponentsLookup.Highlightable);
                matcher.componentNames = GameComponentsLookup.componentNames;
                _matcherHighlightable = matcher;
            }

            return _matcherHighlightable;
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

    static readonly Code.Gameplay.Features.Highlight.Highlightable highlightableComponent = new Code.Gameplay.Features.Highlight.Highlightable();

    public bool isHighlightable {
        get { return HasComponent(GameComponentsLookup.Highlightable); }
        set {
            if (value != isHighlightable) {
                var index = GameComponentsLookup.Highlightable;
                if (value) {
                    var componentPool = GetComponentPool(index);
                    var component = componentPool.Count > 0
                            ? componentPool.Pop()
                            : highlightableComponent;

                    AddComponent(index, component);
                } else {
                    RemoveComponent(index);
                }
            }
        }
    }
}
