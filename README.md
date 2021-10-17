# kasthack.wv2v

## What

HTML string debugger visualizer for Visual Studio that uses WebView2 / Chromium-based Edge component instead of Internet Explorer / WebBrowser one.

[![Github All Releases](https://img.shields.io/github/downloads/kasthack-labs/kasthack.wv2v/total.svg)](https://github.com/kasthack-labs/kasthack.wv2v/releases/latest)
[![GitHub release](https://img.shields.io/github/release/kasthack-labs/kasthack.wv2v.svg)](https://github.com/kasthack-labs/kasthack.wv2v/releases/latest)
[![license](https://img.shields.io/github/license/kasthack-labs/kasthack.wv2v.svg)](LICENSE)
[![.NET Status](https://github.com/kasthack-labs/kasthack.wv2v/workflows/.NET/badge.svg)](https://github.com/kasthack-labs/kasthack.wv2v/actions?query=workflow%3A.NET)
[![CodeQL](https://github.com/kasthack-labs/kasthack.wv2v/workflows/CodeQL/badge.svg)](https://github.com/kasthack-labs/kasthack.wv2v/actions?query=workflow%3ACodeQL)
[![Patreon pledges](https://img.shields.io/endpoint.svg?url=https%3A%2F%2Fshieldsio-patreon.vercel.app%2Fapi%3Fusername%3Dkasthack%26type%3Dpledges&style=flat)](https://patreon.com/kasthack)
[![Patreon patrons](https://img.shields.io/endpoint.svg?url=https%3A%2F%2Fshieldsio-patreon.vercel.app%2Fapi%3Fusername%3Dkasthack%26type%3Dpatrons&style=flat)](https://patreon.com/kasthack)

## Why

* Built-in HTML Visualizer uses WebBrowser component built on top of Internet Explorer / Trident engine which is extremely outdated and takes ages(like 30+ seconds) to open a simple page. This was driving me crazy when I was writing a simple scraper tool and needed to see if I got the selector queries right.
* There's a [similar tool](https://github.com/eladnava/chrome-visualizer/) but
    * It's dead with the last commit made in 2016
    * It uses Google Chrome instead of the built-in browser

## Usage

Instal VSIX from VS extension gallery.