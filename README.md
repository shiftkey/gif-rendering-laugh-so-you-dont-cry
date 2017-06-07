# Gif Rendering issue with WPF

See https://github.com/desktop/desktop/issues/405#issuecomment-300821800 for context.

Probably requires VS2017 to build and run, but you should see this quickly trigger an OOM
while it tries to render a non-trivial GIF inside a WPF Window.