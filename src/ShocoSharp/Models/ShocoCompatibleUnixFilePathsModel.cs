namespace ShocoSharp.Models
{
    public class ShocoCompatibleUnixFilePathsModel : ShocoModel
    {
        public static ShocoCompatibleUnixFilePathsModel Instance { get; } = new ShocoCompatibleUnixFilePathsModel();

        private ShocoCompatibleUnixFilePathsModel()
            : base(MinimumCharacter: 45,
                  MaximumCharacter: 121,
                  MaximumSuccessorLength: 8,
                  CharactersById: new byte[32] {
                       (byte)'/',  (byte)'e',  (byte)'s',  (byte)'r',  (byte)'o',  (byte)'i',  (byte)'t',  (byte)'c',  (byte)'a',  (byte)'n',  (byte)'m',
                       (byte)'l',  (byte)'h',  (byte)'.',  (byte)'u',  (byte)'d',  (byte)'g',  (byte)'b',  (byte)'p',  (byte)'-',  (byte)'f',  (byte)'2',
                       (byte)'k',  (byte)'0',  (byte)'_',  (byte)'1',  (byte)'3',  (byte)'v',  (byte)'4',  (byte)'x',  (byte)'6',  (byte)'w' },
                  IdsByCharacter: new byte[256] {
                      255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
                      255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255,  19,  13,   0,  23,  25,  21,  26,  28, 255,  30, 255, 255, 255, 255, 255, 255, 255, 255, 255,
                      255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255,  24,
                      255,   8,  17,   7,  15,   1,  20,  16,  12,   5, 255,  22,  11,  10,   9,   4,  18, 255,   3,   2,   6,  14,  27,  31,  29, 255, 255, 255, 255, 255, 255, 255,
                      255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
                      255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
                      255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255,
                      255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255 },
                  SuccessorIdsByCharacterId: new byte[32, 32] {
                      {255, 255,   0, 255, 255,   9,   4,   1, 255, 255,  12,   6,   2,  11,   5,  10,   3, 255,   7, 255,  15, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255,   8},
                      {  0, 255,   2,   1, 255, 255,  10,   7,  12,   5,   9,   6, 255,  13, 255,  11, 255,   3,  15,   8, 255, 255, 255, 255,  14, 255, 255, 255, 255,   4, 255, 255},
                      {  1,   5,   6,   2,   3,   9,   0,   7, 255, 255, 255, 255,   4,   8,  13, 255, 255, 255,  12,  10, 255, 255,  14, 255, 255, 255, 255,  15, 255, 255, 255, 255},
                      {  3,   1,   9, 255,   4,   0,   6,   2,   5,  12,   7,  15, 255,   8,  11,  14, 255, 255, 255,  13, 255, 255, 255, 255, 255, 255, 255,  10, 255, 255, 255, 255},
                      {  7, 255,  12,   2,   8, 255,  11,   5,   9,   3,   0,   6, 255, 255,   1,   4,  15,  10,  13, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255,  14},
                      { 14,  15,   0,  13,   8, 255,   2,   5,   1,   4,  12,   6, 255, 255, 255,   9,  11,   3,  10, 255, 255, 255, 255, 255, 255, 255, 255,   7, 255, 255, 255, 255},
                      {  2,   1,   5,   7,   8,   0, 255,  15,   4, 255,  14, 255,   9,  10, 255, 255,   6, 255, 255,  11,  12, 255,   3, 255, 255, 255, 255, 255, 255, 255, 255, 255},
                      {  3,   1,  11,   8,   2, 255,   5,  12,   4, 255, 255,   7,   0,  13,  14, 255, 255,  15,  10, 255, 255,   9,   6, 255, 255, 255, 255, 255, 255, 255, 255, 255},
                      { 12, 255,   4,   1, 255,  10,   2,   5, 255,   0,  11,   3, 255, 255,  15,   9,   6,  13,   8,   7, 255, 255, 255, 255, 255, 255, 255,  14, 255, 255, 255, 255},
                      {  0,   6,   4, 255,   1,  10,   2,   7,  12, 255, 255, 255, 255,  13,  11,   5,   3, 255, 255,   8,   9, 255,  14, 255, 255, 255,  15, 255, 255, 255, 255, 255},
                      {  4,   0,   8, 255,   3,   9, 255, 255,   1, 255,  12,   6, 255,  14,  15,   7, 255,  11,   2,  13,   5, 255, 255, 255,  10, 255, 255, 255, 255, 255, 255, 255},
                      {  4,   1,   7, 255,   3,   0,  11, 255,   2, 255, 255,   5, 255,  12,   6,   9, 255, 255,   8,  10, 255, 255,  13, 255, 255, 255, 255,  14, 255, 255, 255, 255},
                      {  6,   3, 255,   1,   0,   5,   4, 255,   2, 255,  13, 255, 255,   8,  15, 255,  10, 255,   9,  11, 255, 255, 255, 255,  12, 255, 255, 255, 255, 255, 255, 255},
                      {255, 255, 255, 255,  12, 255, 255,   5, 255, 255,  13,   4,   2, 255, 255,   9,   7, 255,   0, 255,  10,  14, 255,   8, 255,   3,   1, 255,  11, 255, 255, 255},
                      { 12,  14,   1,   0, 255,   7,   5, 255,  15,   3,   2,   4, 255, 255, 255,   6,   9,  10,   8, 255,  11, 255, 255, 255, 255, 255, 255, 255, 255,  13, 255, 255},
                      {  3,   0,   6,  13,   2,   1, 255, 255,   4, 255, 255,  12, 255,  10,   7,  15, 255,   5, 255,   8,  14, 255, 255, 255,  11, 255, 255, 255, 255, 255, 255, 255},
                      {  4,   2,   6,   5,   8,   3,   1, 255, 255,   0, 255,   7,  10,   9,  12,  14, 255,  15, 255,  13, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255},
                      {  1,   5,   6, 255,  11,  13, 255,  15,   3, 255, 255,   8, 255, 255,   4, 255,  14, 255, 255, 255, 255, 255,   0, 255, 255, 255, 255, 255, 255, 255,  12, 255},
                      {  5,   2,   8,   7,   6,  10,   9,  13,   0,   3,  15,   1,  14, 255,  12, 255, 255, 255,   4, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255},
                      {255,  15,   2, 255, 255, 255,   4,   6, 255,  14,  12,   9, 255, 255, 255,   1,   8,  13,   3, 255,   7,   0, 255,  11, 255,   5, 255, 255, 255,  10, 255, 255},
                      {  7,   5,  11,   9,   0,   1, 255,   2,   4, 255,   6, 255, 255,  13, 255,  10, 255,  12, 255,   3,   8,  15, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255},
                      {  2, 255, 255, 255, 255, 255, 255,  15,  14, 255, 255, 255, 255,   0, 255, 255, 255, 255, 255,   8, 255,   4, 255,   1, 255,  12,  11, 255,   3,  13,   7, 255},
                      {  3,   2,   6, 255,  10,   0,  12, 255,   5,   8, 255,  11, 255,   7, 255,  13, 255,  15, 255,   1, 255, 255, 255, 255,   4, 255, 255, 255, 255, 255, 255, 255},
                      {  2, 255, 255, 255, 255, 255, 255, 255,  15, 255, 255, 255, 255,   0, 255, 255, 255, 255, 255,   3, 255,   6, 255,   1,   5,   4,   8, 255,   9, 255,  12, 255},
                      {255, 255,   4,  10, 255, 255,   8,  11, 255, 255,   6,   0, 255, 255, 255,  14, 255,  15,   3, 255, 255, 255, 255,   2,  13,   9,   5, 255, 255, 255,   1,  12},
                      {  0, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255,   1, 255,  14, 255,  15, 255,   9, 255,   5, 255,   2,  13,   4,   3, 255,   7, 255,   6, 255},
                      {  1, 255, 255, 255, 255, 255, 255, 255,  14, 255, 255, 255, 255,   0, 255,  15, 255, 255, 255,  13, 255,   2, 255,   5,   3,   6,   7, 255,   9, 255,  11, 255},
                      {  8,   0,  13, 255,   3,   2, 255,   9,   1,   6,   5, 255, 255,  10, 255,  15,   4, 255,  14,  12,   7, 255, 255, 255,  11, 255, 255, 255, 255, 255, 255, 255},
                      {  0,  14, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255, 255,   1, 255, 255, 255,  13, 255,   2,  15,  10, 255,   3, 255,   5,   7, 255,   8, 255,  12, 255},
                      {  3,   9, 255, 255, 255, 255,   4, 255,   8, 255,   0,   1, 255,  10, 255, 255, 255, 255,  11,   5, 255,   6, 255, 255,  14,  13,  15, 255,  12, 255, 255, 255},
                      {  2, 255, 255, 255, 255, 255, 255, 255,  13, 255, 255, 255, 255,   4, 255,  15, 255,  14, 255, 255, 255,   3, 255,   5,   1,   9,   7, 255,   0, 255,   6, 255},
                      { 11,   0,  10,   9,   3,   1,  12,  15,   2,   4,   6, 255,  13,   7, 255,  14, 255, 255, 255,   8, 255, 255, 255, 255,   5, 255, 255, 255, 255, 255, 255, 255} },
                  CharactersBySuccessorId: new byte[76, 16] {
                      { (byte)'2',  (byte)'d',  (byte)'s',  (byte)'p',  (byte)'t',  (byte)'1',  (byte)'c',  (byte)'f',  (byte)'g',  (byte)'l',  (byte)'x',  (byte)'0',  (byte)'m',  (byte)'b',  (byte)'n',  (byte)'e'},
                      { (byte)'p',  (byte)'3',  (byte)'h',  (byte)'1',  (byte)'l',  (byte)'c',  (byte)'9',  (byte)'g',  (byte)'0',  (byte)'d',  (byte)'f',  (byte)'4',  (byte)'o',  (byte)'m',  (byte)'2',  (byte)'P'},
                      { (byte)'s',  (byte)'c',  (byte)'h',  (byte)'g',  (byte)'t',  (byte)'u',  (byte)'l',  (byte)'p',  (byte)'w',  (byte)'i',  (byte)'d',  (byte)'.',  (byte)'m',  (byte)'S',  (byte)'W',  (byte)'f'},
                      { (byte)'.',  (byte)'0',  (byte)'/',  (byte)'-',  (byte)'1',  (byte)'_',  (byte)'2',  (byte)'9',  (byte)'3',  (byte)'4',  (byte)'7',  (byte)'8',  (byte)'6',  (byte)'5',  (byte)':',  (byte)'a'},
                      { (byte)'/',  (byte)'.',  (byte)'0',  (byte)'3',  (byte)'1',  (byte)'2',  (byte)'6',  (byte)'4',  (byte)'5',  (byte)'-',  (byte)'7',  (byte)'8',  (byte)'9',  (byte)'_',  (byte)'d',  (byte)'b'},
                      { (byte)'.',  (byte)'0',  (byte)'/',  (byte)'4',  (byte)'2',  (byte)'8',  (byte)'5',  (byte)'6',  (byte)'-',  (byte)'7',  (byte)'9',  (byte)'3',  (byte)'1',  (byte)'x',  (byte)'a',  (byte)'c'},
                      { (byte)'.',  (byte)'/',  (byte)'2',  (byte)'_',  (byte)'7',  (byte)'0',  (byte)'1',  (byte)'3',  (byte)'8',  (byte)'4',  (byte)'5',  (byte)'6',  (byte)'9',  (byte)'-',  (byte)'a',  (byte)'d'},
                      { (byte)'/',  (byte)'.',  (byte)'-',  (byte)'0',  (byte)'8',  (byte)'1',  (byte)'5',  (byte)'3',  (byte)'4',  (byte)'9',  (byte)'2',  (byte)'7',  (byte)'6',  (byte)'b',  (byte)'e',  (byte)'f'},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      { (byte)'4',  (byte)'_',  (byte)'/',  (byte)'2',  (byte)'.',  (byte)'0',  (byte)'6',  (byte)'3',  (byte)'8',  (byte)'1',  (byte)'7',  (byte)'9',  (byte)'5',  (byte)'a',  (byte)'b',  (byte)'d'},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      { (byte)'l',  (byte)'6',  (byte)'0',  (byte)'p',  (byte)'s',  (byte)'3',  (byte)'m',  (byte)'M',  (byte)'t',  (byte)'1',  (byte)'r',  (byte)'c',  (byte)'w',  (byte)'_',  (byte)'d',  (byte)'b'},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      { (byte)'n',  (byte)'r',  (byte)'t',  (byte)'l',  (byte)'s',  (byte)'c',  (byte)'g',  (byte)'-',  (byte)'p',  (byte)'d',  (byte)'i',  (byte)'m',  (byte)'/',  (byte)'b',  (byte)'v',  (byte)'u'},
                      { (byte)'k',  (byte)'/',  (byte)'C',  (byte)'a',  (byte)'u',  (byte)'e',  (byte)'s',  (byte)'j',  (byte)'l',  (byte)'K',  (byte)'W',  (byte)'o',  (byte)'6',  (byte)'i',  (byte)'g',  (byte)'c'},
                      { (byte)'h',  (byte)'e',  (byte)'o',  (byte)'/',  (byte)'a',  (byte)'t',  (byte)'k',  (byte)'l',  (byte)'r',  (byte)'2',  (byte)'p',  (byte)'s',  (byte)'c',  (byte)'.',  (byte)'u',  (byte)'b'},
                      { (byte)'e',  (byte)'i',  (byte)'o',  (byte)'/',  (byte)'a',  (byte)'b',  (byte)'s',  (byte)'u',  (byte)'-',  (byte)'S',  (byte)'.',  (byte)'_',  (byte)'l',  (byte)'r',  (byte)'f',  (byte)'d'},
                      { (byte)'/',  (byte)'r',  (byte)'s',  (byte)'b',  (byte)'x',  (byte)'n',  (byte)'l',  (byte)'c',  (byte)'-',  (byte)'m',  (byte)'t',  (byte)'d',  (byte)'a',  (byte)'.',  (byte)'_',  (byte)'p'},
                      { (byte)'o',  (byte)'i',  (byte)'c',  (byte)'-',  (byte)'a',  (byte)'e',  (byte)'m',  (byte)'/',  (byte)'f',  (byte)'r',  (byte)'d',  (byte)'s',  (byte)'b',  (byte)'.',  (byte)'8',  (byte)'2'},
                      { (byte)'n',  (byte)'t',  (byte)'e',  (byte)'i',  (byte)'/',  (byte)'r',  (byte)'s',  (byte)'l',  (byte)'o',  (byte)'.',  (byte)'h',  (byte)'z',  (byte)'u',  (byte)'-',  (byte)'d',  (byte)'b'},
                      { (byte)'o',  (byte)'r',  (byte)'a',  (byte)'e',  (byte)'t',  (byte)'i',  (byte)'/',  (byte)'y',  (byte)'.',  (byte)'p',  (byte)'g',  (byte)'-',  (byte)'_',  (byte)'m',  (byte)'C',  (byte)'u'},
                      { (byte)'s',  (byte)'a',  (byte)'t',  (byte)'b',  (byte)'n',  (byte)'c',  (byte)'l',  (byte)'v',  (byte)'o',  (byte)'d',  (byte)'p',  (byte)'g',  (byte)'m',  (byte)'r',  (byte)'/',  (byte)'e'},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      { (byte)'i',  (byte)'-',  (byte)'e',  (byte)'/',  (byte)'_',  (byte)'a',  (byte)'s',  (byte)'.',  (byte)'n',  (byte)'+',  (byte)'o',  (byte)'l',  (byte)'t',  (byte)'d',  (byte)'M',  (byte)'b'},
                      { (byte)'i',  (byte)'e',  (byte)'a',  (byte)'o',  (byte)'/',  (byte)'l',  (byte)'u',  (byte)'s',  (byte)'p',  (byte)'d',  (byte)'-',  (byte)'t',  (byte)'.',  (byte)'k',  (byte)'v',  (byte)'y'},
                      { (byte)'e',  (byte)'a',  (byte)'p',  (byte)'o',  (byte)'/',  (byte)'f',  (byte)'l',  (byte)'d',  (byte)'s',  (byte)'i',  (byte)'_',  (byte)'b',  (byte)'m',  (byte)'-',  (byte)'.',  (byte)'u'},
                      { (byte)'/',  (byte)'o',  (byte)'t',  (byte)'g',  (byte)'s',  (byte)'d',  (byte)'e',  (byte)'c',  (byte)'-',  (byte)'f',  (byte)'i',  (byte)'u',  (byte)'a',  (byte)'.',  (byte)'k',  (byte)'3'},
                      { (byte)'m',  (byte)'u',  (byte)'r',  (byte)'n',  (byte)'d',  (byte)'c',  (byte)'l',  (byte)'/',  (byte)'o',  (byte)'a',  (byte)'b',  (byte)'t',  (byte)'s',  (byte)'p',  (byte)'w',  (byte)'g'},
                      { (byte)'a',  (byte)'l',  (byte)'e',  (byte)'n',  (byte)'p',  (byte)'/',  (byte)'o',  (byte)'r',  (byte)'s',  (byte)'t',  (byte)'i',  (byte)'y',  (byte)'u',  (byte)'c',  (byte)'h',  (byte)'m'},
                      {      0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00,       0x00},
                      { (byte)'i',  (byte)'e',  (byte)'c',  (byte)'/',  (byte)'o',  (byte)'a',  (byte)'t',  (byte)'m',  (byte)'.',  (byte)'s',  (byte)'v',  (byte)'u',  (byte)'n',  (byte)'-',  (byte)'d',  (byte)'l'},
                      { (byte)'t',  (byte)'/',  (byte)'r',  (byte)'o',  (byte)'h',  (byte)'e',  (byte)'s',  (byte)'c',  (byte)'.',  (byte)'i',  (byte)'-',  (byte)'y',  (byte)'p',  (byte)'u',  (byte)'k',  (byte)'v'},
                      { (byte)'i',  (byte)'e',  (byte)'/',  (byte)'k',  (byte)'a',  (byte)'s',  (byte)'g',  (byte)'r',  (byte)'o',  (byte)'h',  (byte)'.',  (byte)'-',  (byte)'f',  (byte)'y',  (byte)'m',  (byte)'c'},
                      { (byte)'r',  (byte)'s',  (byte)'m',  (byte)'n',  (byte)'l',  (byte)'t',  (byte)'d',  (byte)'i',  (byte)'p',  (byte)'g',  (byte)'b',  (byte)'f',  (byte)'/',  (byte)'x',  (byte)'e',  (byte)'a'},
                      { (byte)'e',  (byte)'a',  (byte)'i',  (byte)'o',  (byte)'g',  (byte)'m',  (byte)'n',  (byte)'f',  (byte)'/',  (byte)'c',  (byte)'.',  (byte)'_',  (byte)'-',  (byte)'s',  (byte)'p',  (byte)'d'},
                      { (byte)'e',  (byte)'i',  (byte)'a',  (byte)'o',  (byte)'n',  (byte)'_',  (byte)'m',  (byte)'.',  (byte)'-',  (byte)'r',  (byte)'s',  (byte)'/',  (byte)'t',  (byte)'h',  (byte)'d',  (byte)'c'},
                      { (byte)'m',  (byte)'l',  (byte)'8',  (byte)'/',  (byte)'t',  (byte)'-',  (byte)'2',  (byte)'y',  (byte)'a',  (byte)'e',  (byte)'.',  (byte)'p',  (byte)'4',  (byte)'1',  (byte)'_',  (byte)'3'} },
                  Packs: new ShocoPack[] {
                      new ShocoPack(0x80, 1, 2, new int[] { 26, 24, 24, 24, 24, 24, 24 }, new int[] { 15, 3, 0, 0, 0, 0, 0 }),
                      new ShocoPack(0xC0, 2, 4, new int[] { 25, 21, 18, 16, 16, 16, 16 }, new int[] { 15, 15, 7, 3, 0, 0, 0 }),
                      new ShocoPack(0xE0, 4, 8, new int[] { 24, 20, 16, 12, 9, 6, 3, 0 }, new int[] { 15, 15, 15, 15, 7, 7, 7, 7 }) })
        { }

    }
}
