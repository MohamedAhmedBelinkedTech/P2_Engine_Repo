#!/usr/bin/env bash
set -e
git init -b main
git add .
git commit -m "Initial baseline structure"
git tag v0.1.0-baseline
# git submodule add ../P2_Testing_Repo.git testing/P2_Testing
git checkout -b feature/frequency-tracking main
# apply files from branches/feature__frequency-tracking/commit_01_*/snapshot
git add . && git commit -m "Add zero crossing frequency estimator"
# apply files from branches/feature__frequency-tracking/commit_02_*/snapshot
git add . && git commit -m "Add frequency tracking notes"
# apply files from branches/feature__frequency-tracking/commit_03_*/snapshot
git add . && git commit -m "Add frequency event range constants"
git checkout -b feature/harmonic-summary main
# apply files from branches/feature__harmonic-summary/commit_01_*/snapshot
git add . && git commit -m "Add harmonic summary DTO"
# apply files from branches/feature__harmonic-summary/commit_02_*/snapshot
git add . && git commit -m "Add simplified harmonic calculator"
# apply files from branches/feature__harmonic-summary/commit_03_*/snapshot
git add . && git commit -m "Document harmonic summary flow"
git checkout -b feature/dc-offset-guard main
# apply files from branches/feature__dc-offset-guard/commit_01_*/snapshot
git add . && git commit -m "Add DC offset guard calculation"
# apply files from branches/feature__dc-offset-guard/commit_02_*/snapshot
git add . && git commit -m "Add guard condition event names"
# apply files from branches/feature__dc-offset-guard/commit_03_*/snapshot
git add . && git commit -m "Document DC offset guard branch"
git tag v0.2.0-training-demo 772281d9d011
