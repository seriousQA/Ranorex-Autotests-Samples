# Ranorex-Autotests-Samples

A few autotests samples for a Windows-based desktop application using Ranorex (C#).
Data driving testing (DDT). Data source: SimpleDataConnector.

## Requirements:
* Windows
* Ranorex Studio

## Solution TestProduct contains:

## Geodetic coordinates in Geocentric coordinates smart folder with 2 Test Cases:
1. **WGS84(G1150)(BLHe)inWGS84(G1150)(XYZ)** XYZ data. Rows:4.
Description: Geodetic coordinates in Geocentric coordinates. WGS84 (G1150) in WGS84 (G1150).
2. **CK42(BLHe)inCK42(XYZ)** XYZ data. Rows:3.
Description: Geodetic coordinates in Geocentric coordinates. CK42 (GOST 32453-2017) in CK42 (GOST 32453-2017).

## Geocentric coordinates in Geodetic coordinates smart folder with 2 Test Cases:
3 **WGS84(XYZ)inWGS84(BLHe)** BLHe data. Rows:5.
Description: Geocentric coordinates in Geodetic coordinates. WGS84 in WGS84.
4. **PZ90(XYZ)inPZ90(BLHe)** BLHe data. Rows:4.
Description: Geocentric coordinates in Geodetic coordinates. PZ90 in PZ90.

## Gauss-Kruger Projection smart folder with 2 Test Cases:
5. **CK42(BL)inCK42zone5(NE)** NE data. Rows:5.
Description: Geodetic coordinates in Plane coordinates. CK42 in CK42 (6 degrees) zone 5.
6. **CK42zone5(NE)inCK42(BL)** BL data. Rows:4.
Description: Plane coordinates in Geodetic coordinates. CK42 (6 degrees) zone 5 in CK42.

## Practice_exercises smart folder with 5 Test Cases:
7. **Local(NE)inLocal(NE)**_ NE data. Rows:3.
Description: Local coordinate system in Local coordinate system.
8. **CK42zone24(NE)inCK42zone25(NE)** NE data. Rows:3.
Description: Plane coordinates in Plane coordinates. CK42 (6 degrees) zone 24 in CK42 (6 degrees) zone 25.
9. **CK42(NE)inCK42(NE)** NE data. Rows:3.
Description: Plane coordinates in Plane coordinates. CK42 (6 degrees) zone 24 in CK42 (3 degrees) zone 47.
10. **CK42(NE)inCK63(NE)** NE data. Rows:3.
Description: Plane coordinates in Plane coordinates. CK42 (3 degrees) zone 47 in CK63 (non-standard) zone 1.
11. **CK42(NE)inMCK(NE)** NE data. Rows:3.
Description: Plane coordinates in Plane coordinates. CK42 (3 degrees) zone 47 in MCK (non-standard) zone 1.

## Geodetic coordinates in Plane coordinates smart folder with 4 Test Cases:
12. **CK42(BLHe)inCK42zone6(NEH)** NEH data. Rows:2.
Description: Geodetic coordinates in Plane coordinates. CK42 (GOST 32453-2017) in CK42 (6 degrees) zone 6.
13. **CK42(BLH)inCK42zone8(NEH)** NEH data. Rows:2.
Description: Geodetic coordinates in Plane coordinates. CK42 (GOST 32453-2017) in CK42 (6 degrees) zone 8.
14. **CK95(BLH)inCK95zone11(NEH)** NEH data. Rows:2.
Description: Geodetic coordinates in Plane coordinates. CK95 (GOST 32453-2017) in CK95 (6 degrees) zone 11.
15. **CK95(BLH)inCK95zone15(NEH)** NEH data. Rows:2.
Description: Geodetic coordinates in Plane coordinates. CK95 (GOST 32453-2017) in CK95 (6 degrees) zone 15.

## Lambert Conformal Conic Projection (1-2SP) smart folder with 4 Test Cases:
16. **WGS84(BL)inLambert1SP(NE)** NE data. Rows:7.
Description: Geodetic coordinates in Plane coordinates. WGS84 (Clarke 1866) in Lambert 1SP.
17. **LambertSP1(NE)inWGS84(BL)** BL data. Rows:7.
Description: Plane coordinates in Geodetic coordinates. Lambert 1SP in WGS84 (Clarke 1866).
18. **CK42(BL)inLambert2SP(NE)** NE data. Rows:7.
Description: Geodetic coordinates in Plane coordinates. CK42 (GOST 32453-2017) in Lambert 2SP.
19. **Lambert2SP(NE)inCK42(BL)** BL data. Rows:7.
Description: Plane coordinates in Geodetic coordinates. Lambert 2SP in CK42 (GOST 32453-2017).

## Plane coordinates in Geodetic coordinates smart folder with 4 Test Cases:
20. **CK42zone13(NEH)inCK42(BLH)** BLH data. Rows:2.
Description: Plane coordinates in Geodetic coordinates. CK42 (6 degrees) zone 13 in CK42 (GOST 32453-2017).
21. **CK42zone22(NEH)inCK42(BLH)** BLH data. Rows:2.
Description: Plane coordinates in Geodetic coordinates. CK42 (6 degrees) zone 22 in CK42 (GOST 32453-2017).
22. **CK95zone5(NEH)inCK95(BLH)** BLH data. Rows:2.
Description: Plane coordinates in Geodetic coordinates. CK95 (6 degrees) zone 5 in CK95 (GOST 32453-2017).
23. **CK95zone7(NEH)inCK95(BLH)** BLH data. Rows:2.
Description: Plane coordinates in Geodetic coordinates. CK95 (6 degrees) zone 7 in CK95 (GOST 32453-2017).

![Test Cases 2](https://user-images.githubusercontent.com/105988683/212549942-87ce5711-0b28-457c-8b90-4d9757bd3c2f.jpg)

