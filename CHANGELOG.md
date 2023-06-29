# Change Log

All notable changes to this project will be documented in this file.

The noted changes will be purely package related changes between releases, and does not cover changes to the repository it is developed within.

## [Unreleased]

## [2.2.0] - 2023-06-29

### Added

- Added Configurable Bound Type (Trigger Bound Update On: Mouse Event, Polling (every tick), Both (Default))

### Updated

- Updated default bound type from Mouse Event (implied prior) to Both
- Updated "Only Bound When Focused" to pause on minimize
- Updated bound status text to indicate paused state

### Fixed

- Fixed performance issue when dealing with lots of Mouse Events
- Fixed bug with Mouse Move Event not getting unsubscribed from

### Removed

- Removed bound status from window titlebar
- Removed Tool Tips from Tool Bar

## [2.1.0] - 2023-06-29

### Added

- Added Switch to Process on Bound
- Added Windows ARM Processor Support

### Updated

- No longer requires .NET installation for use
- Updated to be standalone portable file

### Fixed

- Fixed missing file icon

## [2.0.0] - 2022-04-25

### Added

- Added process list filtering to remove processes without windows.
- Mouse binding now uses hooks to prevent mouse from leaving bounds.
- Options now automatically save when selected.

### Removed

- Removed border offset setting.
- Removed Process ID from Process list.
- Removed Manual Mode.

### Changed

- Mouse Bounder is now exported as a portable executable.
- Changelog changed to adhere to [KeepAChangeLog](https://keepachangelog.com).
- Options are now located in a dropdown menu.
- About is now located in the toolbar.
- Updated Help Window UI.
- Updated Process List Auto-Completion.

### Fixed

- Fixed bug with mouse temporarily leaving bounds if you move quickly.
- Fixed bug with minimizing causing mouse to get stuck.

## [1.2.2] - 2022-01-23

If your on a 64 bit PC use x64, if your on 32 bit use x86.

To update, simply download the executable, extract it to a folder, and run `Mouse-Bounder.exe`.

### Fixed

- Fix bug bound text not resetting when bound app closes

## [1.2.1] - 2022-01-21

If your on a 64 bit PC use x64, if your on 32 bit use x86.

To update, simply download the executable, extract it to a folder, and run `Mouse-Bounder.exe`.

### Fixed

Fixed bug with remembered processes containing process IDs making them unable to bound

## [1.2.0] - 2022-01-21

If your on a 64 bit PC use x64, if your on 32 bit use x86.

To update, simply download the executable, extract it to a folder, and run `Mouse-Bounder.exe`.

### Added

- Added file icon
- Added "Help" section
- Added option Always on Top
- Added option Auto-Bind to Remembered Processes

### Changed

- Updated to unbind when child form is created

### Fixed

- Fixed bug with form closing causing thread exception

## [1.1.0] - 2022-01-21

If your on a 64 bit PC use x64, if your on 32 bit use x86.

To update, simply download the executable, extract it to a folder, and run `Mouse-Bounder.exe`.

### Added

- Added Manual Mode
- Added Autocomplete to Process list
- Added bounding to another process while bounded will switch
- Added Process ID to process list
- Added "About" section
- Added "Options" section
- Added border offset option
- Added option to remember process
- Added option to bind only when application is focused
- Added [Bounded] to title when bounded
- Added [Paused] when process not focused
- Added "Bound to: {Process}"

### Changed

- Updated version to be in About section

### Fixed

- Fixed bug with bounding to an application while bounded.

## [1.0.2] - 2022-01-16

If your on a 64 bit PC use x64, if your on 32 bit use x86.

To update, simply download the executable, extract it to a folder, and run `Mouse-Bounder.exe`.

### Fixed

- Fix bug with closing app causing mouse to get locked

## [1.0.1] - 2022-01-16

If your on a 64 bit PC use x64, if your on 32 bit use x86.

To update, simply download the executable, extract it to a folder, and run `Mouse-Bounder.exe`.

Resizing of the application was unintended behaviour, as the UI doesn't scale well.
As such, it has been removed.

### Changed

- Disabled resizing of application

### Fixed

- Fixed bug with unbound not working unless process was selected

## [1.0.0] - 2022-01-11

If your on a 64 bit PC use x64, if your on 32 bit use x86.

Initial release

[Unreleased]: https://github.com/kdserra/Mouse-Bounder/compare/v2.2.0...dev
[2.2.0]: https://github.com/kdserra/Mouse-Bounder/releases/tag/v2.2.0
[2.1.0]: https://github.com/kdserra/Mouse-Bounder/releases/tag/v2.1.0
[2.0.0]: https://github.com/kdserra/Mouse-Bounder/releases/tag/v2.0.0
[1.2.2]: https://github.com/kdserra/Mouse-Bounder/releases/tag/v1.2.2
[1.2.1]: https://github.com/kdserra/Mouse-Bounder/releases/tag/v1.2.1
[1.2.0]: https://github.com/kdserra/Mouse-Bounder/releases/tag/v1.2.0
[1.1.0]: https://github.com/kdserra/Mouse-Bounder/releases/tag/v1.1.0
[1.0.2]: https://github.com/kdserra/Mouse-Bounder/releases/tag/v1.0.2
[1.0.1]: https://github.com/kdserra/Mouse-Bounder/releases/tag/v1.0.1
[1.0.0]: https://github.com/kdserra/Mouse-Bounder/releases/tag/v1.0.0