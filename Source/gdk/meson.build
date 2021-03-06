pkg = 'gdk'
assembly_name = pkg + '-sharp'
symbols = join_paths(meson.current_source_dir(), 'gdk-symbols.xml')

raw_api_fname = join_paths(meson.current_source_dir(), 'gdk-api.raw')
metadata_fname = join_paths(meson.current_source_dir(), 'Gdk.metadata')

configure_file(input: assembly_name + '.dll.config.in',
        output: assembly_name + '.dll.config',
        configuration : remap_dl_data)

if install
    configure_file(input: assembly_name + '-3.0.pc.in',
            output: assembly_name + '-3.0.pc',
            configuration : version_data,
            install_dir: pkg_install_dir)
endif

subdir('generated')

sources = [
    'Atom.cs',
    'Color.cs',
    'Device.cs',
    'Display.cs',
    'DisplayManager.cs',
    'EventButton.cs',
    'EventConfigure.cs',
    'EventCrossing.cs',
    'Event.cs',
    'EventDND.cs',
    'EventExpose.cs',
    'EventFocus.cs',
    'EventGrabBroken.cs',
    'EventKey.cs',
    'EventMotion.cs',
    'EventOwnerChange.cs',
    'EventProperty.cs',
    'EventProximity.cs',
    'EventScroll.cs',
    'EventSelection.cs',
    'EventSetting.cs',
    'EventVisibility.cs',
    'EventWindowState.cs',
    'Global.cs',
    'Key.cs',
    'Keymap.cs',
    'Pixbuf.cs',
    'PixbufAnimation.cs',
    'PixbufFrame.cs',
    'PixbufLoader.cs',
    'Pixdata.cs',
    'Point.cs',
    'Property.cs',
    'Rectangle.cs',
    'RGBA.cs',
    'Screen.cs',
    'Selection.cs',
    'Size.cs',
    'TextProperty.cs',
    'WindowAttr.cs',
    'Window.cs',
]

deps = [glib_sharp, pango_sharp, cairo_sharp, gio_sharp]
gdk_sharp = shared_library(assembly_name, source_gen, sources, assemblyinfo,
        cs_args: ['-unsafe'],
        link_with: deps,
        install: install,
        install_dir: lib_install_dir
)

nuget_infos += [['GdkSharp', gdk_sharp, ['GlibSharp', 'GioSharp', 'AtkSharp']]]
install_infos += [assembly_name, gdk_sharp.full_path()]
gdk_sharp_dep = declare_dependency(link_with: deps + [gdk_sharp])

