# unity-nouha-tushin

> 脳波センサー（MindWave）× Unity 連携プロジェクト

## 概要

NeuroSky MindWave などの脳波センサーと Unity を連携させ、脳波データ（集中度・瞑想度）に応じてオブジェクトを生成するプロジェクトです。

- 集中度（attention）が 90 以上で一定時間持続すると「寿司」オブジェクトを生成
- 瞑想度（meditation）が 80 以上で一定時間持続すると「みかん」オブジェクトを生成
- `MindwaveManager` プラグインを使用して脳波データをリアルタイム取得

## 使用技術

- Unity（C#）
- MindwaveManager（NeuroSky MindWave 連携プラグイン）

## 動作環境 / 注意事項

- NeuroSky MindWave などの BCI（脳波）センサーデバイスが必要です
- MindwaveManager プラグインのセットアップが必要です
- Bluetooth または有線でデバイスを接続した状態で Unity を実行してください

## ライセンス

[![License: MIT](https://img.shields.io/badge/License-MIT-yellow.svg?style=flat-square)](https://opensource.org/licenses/MIT)

このプロジェクトは **MIT ライセンス** のもとで公開しています。  
使用・参考にした際はできる限り作者へのクレジット表記をお願いします。

© 2025 masafykun (https://github.com/masafykun)
