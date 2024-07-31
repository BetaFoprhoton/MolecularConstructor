import numpy as np
import deepmd
class Molecular:
    def __init__(self, atoms, coordinates, cell, pbc):
        self.atoms = atoms
        self.coordinates = coordinates
        