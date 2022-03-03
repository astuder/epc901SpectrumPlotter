# epc901SpectrumPlotter

This software is an adaption of [SpectrumPlotter](https://github.com/g3gg0/SpectrumPlotter) by g3gg0.de for my spectroscope project using the [epc901](https://github.com/astuder/epc901) line sensor.

## Changes compared to original project

* Encapsulated spectroscope API into its own class and replaced it with epc901
* Adapted UI to features of epc901 spectroscope
* Added support for NIST spectral lines (hacky to reuse existing code and structures)
