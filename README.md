# Ranorex-Autotests-Samples

A few autotests samples for a Windows-based desktop application using Ranorex (C#).
Data driving testing (DDT). Data source: SimpleDataConnector.

## Requirements:
* Windows
* Ranorex Studio

## Solution TestProduct contains:

## Geodetic coordinates in Geocentric coordinates smart folder with 2 Test Cases:
**module1_WGS84(G1150)(BLHe)inWGS84(G1150)(XYZ)** XYZ data. Rows:4.
Description: Geodetic coordinates in Geocentric coordinates. WGS84 (G1150) in WGS84 (G1150).
**module2_CK42(BLHe)inCK42(XYZ)** XYZ data. Rows:3.
Description: Geodetic coordinates in Geocentric coordinates. CK42 (GOST 32453-2017) in CK42 (GOST 32453-2017).

## Geocentric coordinates in Geodetic coordinates smart folder with 2 Test Cases:
**module3_WGS84(XYZ)inWGS84(BLHe)** BLHe data. Rows:5.
Description: Geocentric coordinates in Geodetic coordinates. WGS84 in WGS84.
**module4_PZ90(XYZ)inPZ90(BLHe)** BLHe data. Rows:4.
Description: Geocentric coordinates in Geodetic coordinates. PZ90 in PZ90.

## Gauss-Kruger Projection smart folder with 2 Test Cases:
**module5_CK42(BL)inCK42zone5(NE)** NE data. Rows:5.
Description: Geodetic coordinates in Plane coordinates. CK42 in CK42 (6 degrees) zone 5.
**module6_CK42zone5(NE)inCK42(BL)** BL data. Rows:4.
Description: Plane coordinates in Geodetic coordinates. CK42 (6 degrees) zone 5 in CK42.

## Practice_exercises smart folder with 5 Test Cases:
**module7_Local(NE)inLocal(NE)**_ NE data. Rows:3.
Description: Local coordinate system in Local coordinate system.
**module8_CK42zone24(NE)inCK42zone25(NE)** NE data. Rows:3.
Description: Plane coordinates in Plane coordinates. CK42 (6 degrees) zone 24 in CK42 (6 degrees) zone 25.
**module9_CK42(NE)inCK42(NE)** NE data. Rows:3.
Description: Plane coordinates in Plane coordinates. CK42 (6 degrees) zone 24 in CK42 (3 degrees) zone 47.
**module10_CK42(NE)inCK63(NE)** NE data. Rows:3.
Description: Plane coordinates in Plane coordinates. CK42 (3 degrees) zone 47 in CK63 (non-standard) zone 1.
**module11_CK42(NE)inMCK(NE)** NE data. Rows:3.
Description: Plane coordinates in Plane coordinates. CK42 (3 degrees) zone 47 in MCK (non-standard) zone 1.

## Geodetic coordinates in Plane coordinates smart folder with 4 Test Cases:
**module12_CK42(BLHe)inCK42zone6(NEH)** NEH data. Rows:2.
Description: Geodetic coordinates in Plane coordinates. CK42 (GOST 32453-2017) in CK42 (6 degrees) zone 6.
**module13_CK42(BLH)inCK42zone8(NEH)** NEH data. Rows:2.
Description: Geodetic coordinates in Plane coordinates. CK42 (GOST 32453-2017) in CK42 (6 degrees) zone 8.
**module14_CK95(BLH)inCK95zone11(NEH)** NEH data. Rows:2.
Description: Geodetic coordinates in Plane coordinates. CK95 (GOST 32453-2017) in CK95 (6 degrees) zone 11.
**module15_CK95(BLH)inCK95zone15(NEH)** NEH data. Rows:2.
Description: Geodetic coordinates in Plane coordinates. CK95 (GOST 32453-2017) in CK95 (6 degrees) zone 15.

## Lambert Conformal Conic Projection (1-2SP) smart folder with 4 Test Cases:
**module16_WGS84(BL)inLambert1SP(NE)** NE data. Rows:7.
Description: Geodetic coordinates in Plane coordinates. WGS84 (Clarke 1866) in Lambert 1SP.
**module17_LambertSP1(NE)inWGS84(BL)** BL data. Rows:7.
Description: Plane coordinates in Geodetic coordinates. Lambert 1SP in WGS84 (Clarke 1866).
**module18_CK42(BL)inLambert2SP(NE)** NE data. Rows:7.
Description: Geodetic coordinates in Plane coordinates. CK42 (GOST 32453-2017) in Lambert 2SP.
**module19_Lambert2SP(NE)inCK42(BL)** BL data. Rows:7.
Description: Plane coordinates in Geodetic coordinates. Lambert 2SP in CK42 (GOST 32453-2017).

## Plane coordinates in Geodetic coordinates smart folder with 4 Test Cases:
**module20_CK42zone13(NEH)inCK42(BLH)** BLH data. Rows:2.
Description: Plane coordinates in Geodetic coordinates. CK42 (6 degrees) zone 13 in CK42 (GOST 32453-2017).
**module21_CK42zone22(NEH)inCK42(BLH)** BLH data. Rows:2.
Description: Plane coordinates in Geodetic coordinates. CK42 (6 degrees) zone 22 in CK42 (GOST 32453-2017).
**module22_CK95zone5(NEH)inCK95(BLH)** BLH data. Rows:2.
Description: Plane coordinates in Geodetic coordinates. CK95 (6 degrees) zone 5 in CK95 (GOST 32453-2017).
**module23_CK95zone7(NEH)inCK95(BLH)** BLH data. Rows:2.
Description: Plane coordinates in Geodetic coordinates. CK95 (6 degrees) zone 7 in CK95 (GOST 32453-2017).

![Test Cases 2](https://user-images.githubusercontent.com/105988683/212549942-87ce5711-0b28-457c-8b90-4d9757bd3c2f.jpg)

