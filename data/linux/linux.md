### bootable_usb_iso

dd if=*.iso of=/dev/sdb status=progress

### bootable_usb_iso_windows

sudo dd if=Win11_22H2_English_x64v1.iso of=/dev/sdb bs=4M status=progress && sync

### nixos_init

nix-channel --add <https://nixos.org/channels/nixos-unstable> nixos-unstable
nix-channel --update

```txt
ctrl+/=keyboard_shortcuts
ctrl+k=quick_switcher
```
