CREATE DATABASE db_laundry;

USE db_laundry;

CREATE TABLE layanan_laundry (
    id_layanan INT AUTO_INCREMENT PRIMARY KEY,
    nama_layanan VARCHAR(100),
    harga_per_kg INT,
    estimasi_hari INT
);

-- Menampilkan Semua Data (READ)
SELECT * FROM layanan_laundry;

-- Menambah Data (CREATE)
INSERT INTO layanan_laundry (nama_layanan, harga_per_kg, estimasi_hari)
VALUES ('Cuci Express', 10000, 1);

-- Mengubah Data (UPDATE)
UPDATE layanan_laundry
SET nama_layanan = 'Cuci Premium',
    harga_per_kg = 12000,
    estimasi_hari = 2
WHERE id_layanan = 1;

-- Menghapus Data (DELETE)
DELETE FROM layanan_laundry
WHERE id_layanan = 1;

-- Pencarian Data (SEARCH)
SELECT * FROM layanan_laundry
WHERE nama_layanan LIKE '%cuci%';