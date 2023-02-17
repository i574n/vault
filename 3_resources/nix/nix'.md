zenith

microsoft-edge-dev --disable-web-security --ignore-certificate-errors --user-data-dir=/root/.config/microsoft-edge-dev\_/ --no-sandbox & disown
obsidian --no-sandbox & disown
ledger-live-desktop --no-sandbox & disown

DBUS_SESSION_BUS_ADDRESS=unix:path=/run/user/1000/bus ledger-live-desktop --no-sandbox
sudo -H -u alias microsoft-edge-dev
sudo -H -u alias ledger-live-desktop

clear && nixos-rebuild switch --upgrade-all
lapce & disown
xrandr --setprovideroutputsource NVIDIA-G0 modesetting && xrandr --auto
microsoft-edge-dev --no-sandbox & disown
obsidian --no-sandbox & disown

microsoft-edge-dev --disable-web-security --ignore-certificate-errors --user-data-dir=/root/.config/microsoft-edge-dev/ --no-sandbox & disown

---

Here's a complete sequence of commands that you can use to cleanup the NixOS storage, starting with the nix-collect-garbage -d command:

nix-collect-garbage -d: This command collects and deletes any garbage that is not being used by any active generation of the system, and it will also delete the generations of the system that are no longer in use. This step will free up disk space by removing old, unused package versions and old, unused system configurations.

nix-store --optimize: This command optimizes the store by compacting hard links. This step will help you reclaim disk space by removing duplicates of files that are shared between multiple packages.

nix-store --verify: This command verifies the integrity of the store. It checks that the store paths are valid and that all the files are present and not corrupted, this step will help you detect any problem that may be caused by a broken store and ensure the system is still working correctly.

nix-channel --update: This command updates your system channels and also, if newer versions of packages are available, it will download and install them. This step will help you to keep your system up-to-date and reduce the space used by old versions of the packages.

It's important to keep in mind that these commands are cleaning the storage used by your current user, there are other ways to clean the storage used by all users, such as using the find command combined with the nix-store --delete command, but it's always important to be careful when using these commands as they may delete important files and data, it's always a good idea to make sure to have a backup or a snapshot of your system before running these commands.

It's recommended to run these commands in the order I mentioned, as they are building on each other to clear different types of storage issues, also, check your system storage space before and after running these commands, to have a clear view of the impact of each command on your storage.
