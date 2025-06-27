## Policy of View Model to Component
- Variable should only be passed down to view model if it is used or manipulated.
- Therefore, when variable is available on the view model it is mendatory to use it to render and ignore the local parameter.
- Variables should be set on initialize or parameterset depending on logic and then call the ```Initialize``` or ```ParameterRefresh```.
