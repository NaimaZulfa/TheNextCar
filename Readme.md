# TheNextCar
* Class `DoorController.cs` berisi method `close()` `open()` `activateLock()` `unlock()` `isClose()` `isLocked()` dan  `onDoorChanged` yang berfungsi untuk mengontrol Door apakah akan dibuka atau ditutup.
* `Door.cs` sendiri fungsinya sebagai pengatur logic door untuk dibuka atau ditutup.
* Interface `onDoorChanged` berfungsi untuk menampung method `doorSecurityChanged` dan `doorStatusChanged`, serta menyimpan data yang berisi status saat tombol ditekan.