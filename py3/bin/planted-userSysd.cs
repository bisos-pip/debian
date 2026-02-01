#!/usr/bin/env python

####+BEGIN: b:prog:file/particulars :authors ("./inserts/authors-mb.org")
""" #+begin_org
* *[[elisp:(org-cycle)][| Particulars |]]* :: Authors, version
** This File: /bisos/git/auth/bxRepos/bisos-pip/binsprep/py3/bin/exmpl-func-binsPrep.cs
** Authors: Mohsen BANAN, http://mohsen.banan.1.byname.net/contact
#+end_org """
####+END:

""" #+begin_org
* Panel::  [[file:/bisos/panels/bisos-apps/NOTYET/_nodeBase_/fullUsagePanel-en.org]]
* Overview and Relevant Pointers
#+end_org """

# from bisos import b

from bisos.debian import systemd_seedInfo
from bisos.debian import systemd_seed as systemd_seed  # noqa

def sysdUnitFileFunc():
    templateStr = """
[Unit]
Description=Facter Service
Documentation=man:facter(1)

[Service]
ExecStart=/bisos/venv/py3/dev-bisos3/bin/facter-roPerf.cs -v 20 --svcName="svcFacter"  -i csPerformer
Restart=always
RestartSec=60

[Install]
WantedBy=default.target
"""
    return templateStr


systemd_seedInfo.setup(
    seedType="sysdUserUnit",  # or userUnit
    sysdUnitName="facter",
    sysdUnitFileFunc=sysdUnitFileFunc,
)

