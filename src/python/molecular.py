import MDAnalysis as mda
import numpy.linalg

# 在宇宙中创建100个水分子和20个氨气分子,并模拟100步，保存每步内每个原子的坐标
def molecular():
    # 创建一个空白的模拟系统
    u = mda.Universe.empty(120, atom_resnames=['HOH', 'NH3'], n_residues=[100, 20], n_chains=[1, 1], trajectory=True)

    # 设置原子的坐标
    positions = numpy.random.rand(120, 3) * 10.0 - 5.0
    u.atoms.positions = positions

    # 模拟100步
    for i in range(100):
        # 更新原子的坐标
        u.atoms.positions += numpy.random.rand(120, 3) * 0.1 - 0.05
        # 保存当前步的原子的坐标
        u.trajectory.ts.frame = i
        u.trajectory.save()
    return u
