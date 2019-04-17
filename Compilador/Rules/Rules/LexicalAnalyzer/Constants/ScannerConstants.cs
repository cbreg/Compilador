﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rules.LexicalAnalyzer.Constants
{
    public class ScannerConstants
    {
        public int[] SCANNER_TABLE_INDEXES =
    {
         0,
        85,
        85,
        86,
        277,
        278,
        278,
        278,
        278,
        279,
        279,
        280,
        290,
        290,
        301,
        301,
        301,
        302,
        303,
        304,
        304,
        341,
        344,
        344,
        407,
        407,
        407,
        598,
        598,
        598,
        608,
        618,
        618,
        618,
        618,
        618,
        655,
        848,
        858,
        860,
        861,
        1052,
        1052
        };

        public int[,] SCANNER_TABLE =
        {
       {9, 1},
        {10, 1},
        {13, 1},
        {32, 1},
        {33, 2},
        {34, 3},
        {35, 4},
        {40, 5},
        {41, 6},
        {42, 7},
        {43, 8},
        {44, 9},
        {45, 10},
        {46, 11},
        {47, 12},
        {48, 13},
        {49, 13},
        {50, 13},
        {51, 13},
        {52, 13},
        {53, 13},
        {54, 13},
        {55, 13},
        {56, 13},
        {57, 13},
        {58, 14},
        {59, 15},
        {60, 16},
        {61, 17},
        {62, 18},
        {63, 19},
        {65, 20},
        {66, 20},
        {67, 20},
        {68, 20},
        {69, 20},
        {70, 20},
        {71, 20},
        {72, 20},
        {73, 20},
        {74, 20},
        {75, 20},
        {76, 20},
        {77, 20},
        {78, 20},
        {79, 20},
        {80, 20},
        {81, 20},
        {82, 20},
        {83, 20},
        {84, 20},
        {85, 20},
        {86, 20},
        {87, 20},
        {88, 20},
        {89, 20},
        {90, 20},
        {92, 21},
        {94, 22},
        {97, 23},
        {98, 23},
        {99, 23},
        {100, 23},
        {101, 23},
        {102, 23},
        {103, 23},
        {104, 23},
        {105, 23},
        {106, 23},
        {107, 23},
        {108, 23},
        {109, 23},
        {110, 23},
        {111, 23},
        {112, 23},
        {113, 23},
        {114, 23},
        {115, 23},
        {116, 23},
        {117, 23},
        {118, 23},
        {119, 23},
        {120, 23},
        {121, 23},
        {122, 23},
        {61, 24},
        {9, 3},
        {13, 3},
        {32, 3},
        {33, 3},
        {34, 25},
        {35, 3},
        {36, 3},
        {37, 3},
        {38, 3},
        {39, 3},
        {40, 3},
        {41, 3},
        {42, 3},
        {43, 3},
        {44, 3},
        {45, 3},
        {46, 3},
        {47, 3},
        {48, 3},
        {49, 3},
        {50, 3},
        {51, 3},
        {52, 3},
        {53, 3},
        {54, 3},
        {55, 3},
        {56, 3},
        {57, 3},
        {58, 3},
        {59, 3},
        {60, 3},
        {61, 3},
        {62, 3},
        {63, 3},
        {64, 3},
        {65, 3},
        {66, 3},
        {67, 3},
        {68, 3},
        {69, 3},
        {70, 3},
        {71, 3},
        {72, 3},
        {73, 3},
        {74, 3},
        {75, 3},
        {76, 3},
        {77, 3},
        {78, 3},
        {79, 3},
        {80, 3},
        {81, 3},
        {82, 3},
        {83, 3},
        {84, 3},
        {85, 3},
        {86, 3},
        {87, 3},
        {88, 3},
        {89, 3},
        {90, 3},
        {91, 3},
        {93, 3},
        {94, 3},
        {95, 3},
        {96, 3},
        {97, 3},
        {98, 3},
        {99, 3},
        {100, 3},
        {101, 3},
        {102, 3},
        {103, 3},
        {104, 3},
        {105, 3},
        {106, 3},
        {107, 3},
        {108, 3},
        {109, 3},
        {110, 3},
        {111, 3},
        {112, 3},
        {113, 3},
        {114, 3},
        {115, 3},
        {116, 3},
        {117, 3},
        {118, 3},
        {119, 3},
        {120, 3},
        {121, 3},
        {122, 3},
        {123, 3},
        {124, 3},
        {125, 3},
        {126, 3},
        {161, 3},
        {162, 3},
        {163, 3},
        {164, 3},
        {165, 3},
        {166, 3},
        {167, 3},
        {168, 3},
        {169, 3},
        {170, 3},
        {171, 3},
        {172, 3},
        {173, 3},
        {174, 3},
        {175, 3},
        {176, 3},
        {177, 3},
        {178, 3},
        {179, 3},
        {180, 3},
        {181, 3},
        {182, 3},
        {183, 3},
        {184, 3},
        {185, 3},
        {186, 3},
        {187, 3},
        {188, 3},
        {189, 3},
        {190, 3},
        {191, 3},
        {192, 3},
        {193, 3},
        {194, 3},
        {195, 3},
        {196, 3},
        {197, 3},
        {198, 3},
        {199, 3},
        {200, 3},
        {201, 3},
        {202, 3},
        {203, 3},
        {204, 3},
        {205, 3},
        {206, 3},
        {207, 3},
        {208, 3},
        {209, 3},
        {210, 3},
        {211, 3},
        {212, 3},
        {213, 3},
        {214, 3},
        {215, 3},
        {216, 3},
        {217, 3},
        {218, 3},
        {219, 3},
        {220, 3},
        {221, 3},
        {222, 3},
        {223, 3},
        {224, 3},
        {225, 3},
        {226, 3},
        {227, 3},
        {228, 3},
        {229, 3},
        {230, 3},
        {231, 3},
        {232, 3},
        {233, 3},
        {234, 3},
        {235, 3},
        {236, 3},
        {237, 3},
        {238, 3},
        {239, 3},
        {240, 3},
        {241, 3},
        {242, 3},
        {243, 3},
        {244, 3},
        {245, 3},
        {246, 3},
        {247, 3},
        {248, 3},
        {249, 3},
        {250, 3},
        {251, 3},
        {252, 3},
        {253, 3},
        {254, 3},
        {255, 3},
        {124, 26},
        {61, 27},
        {61, 28},
        {48, 29},
        {49, 29},
        {50, 29},
        {51, 29},
        {52, 29},
        {53, 29},
        {54, 29},
        {55, 29},
        {56, 29},
        {57, 29},
        {46, 30},
        {48, 13},
        {49, 13},
        {50, 13},
        {51, 13},
        {52, 13},
        {53, 13},
        {54, 13},
        {55, 13},
        {56, 13},
        {57, 13},
        {61, 31},
        {61, 32},
        {61, 33},
        {48, 20},
        {49, 20},
        {50, 20},
        {51, 20},
        {52, 20},
        {53, 20},
        {54, 20},
        {55, 20},
        {56, 20},
        {57, 20},
        {95, 20},
        {97, 20},
        {98, 20},
        {99, 20},
        {100, 20},
        {101, 20},
        {102, 20},
        {103, 20},
        {104, 20},
        {105, 20},
        {106, 20},
        {107, 20},
        {108, 20},
        {109, 20},
        {110, 20},
        {111, 20},
        {112, 20},
        {113, 20},
        {114, 20},
        {115, 20},
        {116, 20},
        {117, 20},
        {118, 20},
        {119, 20},
        {120, 20},
        {121, 20},
        {122, 20},
        {32, 34},
        {110, 34},
        {116, 34},
        {48, 23},
        {49, 23},
        {50, 23},
        {51, 23},
        {52, 23},
        {53, 23},
        {54, 23},
        {55, 23},
        {56, 23},
        {57, 23},
        {65, 35},
        {66, 35},
        {67, 35},
        {68, 35},
        {69, 35},
        {70, 35},
        {71, 35},
        {72, 35},
        {73, 35},
        {74, 35},
        {75, 35},
        {76, 35},
        {77, 35},
        {78, 35},
        {79, 35},
        {80, 35},
        {81, 35},
        {82, 35},
        {83, 35},
        {84, 35},
        {85, 35},
        {86, 35},
        {87, 35},
        {88, 35},
        {89, 35},
        {90, 35},
        {95, 23},
        {97, 23},
        {98, 23},
        {99, 23},
        {100, 23},
        {101, 23},
        {102, 23},
        {103, 23},
        {104, 23},
        {105, 23},
        {106, 23},
        {107, 23},
        {108, 23},
        {109, 23},
        {110, 23},
        {111, 23},
        {112, 23},
        {113, 23},
        {114, 23},
        {115, 23},
        {116, 23},
        {117, 23},
        {118, 23},
        {119, 23},
        {120, 23},
        {121, 23},
        {122, 23},
        {9, 36},
        {10, 36},
        {13, 36},
        {32, 36},
        {33, 36},
        {34, 36},
        {36, 36},
        {37, 36},
        {38, 36},
        {39, 36},
        {40, 36},
        {41, 36},
        {42, 36},
        {43, 36},
        {44, 36},
        {45, 36},
        {46, 36},
        {47, 36},
        {48, 36},
        {49, 36},
        {50, 36},
        {51, 36},
        {52, 36},
        {53, 36},
        {54, 36},
        {55, 36},
        {56, 36},
        {57, 36},
        {58, 36},
        {59, 36},
        {60, 36},
        {61, 36},
        {62, 36},
        {63, 36},
        {64, 36},
        {65, 36},
        {66, 36},
        {67, 36},
        {68, 36},
        {69, 36},
        {70, 36},
        {71, 36},
        {72, 36},
        {73, 36},
        {74, 36},
        {75, 36},
        {76, 36},
        {77, 36},
        {78, 36},
        {79, 36},
        {80, 36},
        {81, 36},
        {82, 36},
        {83, 36},
        {84, 36},
        {85, 36},
        {86, 36},
        {87, 36},
        {88, 36},
        {89, 36},
        {90, 36},
        {91, 36},
        {92, 36},
        {93, 36},
        {94, 36},
        {95, 36},
        {96, 36},
        {97, 36},
        {98, 36},
        {99, 36},
        {100, 36},
        {101, 36},
        {102, 36},
        {103, 36},
        {104, 36},
        {105, 36},
        {106, 36},
        {107, 36},
        {108, 36},
        {109, 36},
        {110, 36},
        {111, 36},
        {112, 36},
        {113, 36},
        {114, 36},
        {115, 36},
        {116, 36},
        {117, 36},
        {118, 36},
        {119, 36},
        {120, 36},
        {121, 36},
        {122, 36},
        {123, 36},
        {125, 36},
        {126, 36},
        {161, 36},
        {162, 36},
        {163, 36},
        {164, 36},
        {165, 36},
        {166, 36},
        {167, 36},
        {168, 36},
        {169, 36},
        {170, 36},
        {171, 36},
        {172, 36},
        {173, 36},
        {174, 36},
        {175, 36},
        {176, 36},
        {177, 36},
        {178, 36},
        {179, 36},
        {180, 36},
        {181, 36},
        {182, 36},
        {183, 36},
        {184, 36},
        {185, 36},
        {186, 36},
        {187, 36},
        {188, 36},
        {189, 36},
        {190, 36},
        {191, 36},
        {192, 36},
        {193, 36},
        {194, 36},
        {195, 36},
        {196, 36},
        {197, 36},
        {198, 36},
        {199, 36},
        {200, 36},
        {201, 36},
        {202, 36},
        {203, 36},
        {204, 36},
        {205, 36},
        {206, 36},
        {207, 36},
        {208, 36},
        {209, 36},
        {210, 36},
        {211, 36},
        {212, 36},
        {213, 36},
        {214, 36},
        {215, 36},
        {216, 36},
        {217, 36},
        {218, 36},
        {219, 36},
        {220, 36},
        {221, 36},
        {222, 36},
        {223, 36},
        {224, 36},
        {225, 36},
        {226, 36},
        {227, 36},
        {228, 36},
        {229, 36},
        {230, 36},
        {231, 36},
        {232, 36},
        {233, 36},
        {234, 36},
        {235, 36},
        {236, 36},
        {237, 36},
        {238, 36},
        {239, 36},
        {240, 36},
        {241, 36},
        {242, 36},
        {243, 36},
        {244, 36},
        {245, 36},
        {246, 36},
        {247, 36},
        {248, 36},
        {249, 36},
        {250, 36},
        {251, 36},
        {252, 36},
        {253, 36},
        {254, 36},
        {255, 36},
        {48, 37},
        {49, 29},
        {50, 29},
        {51, 29},
        {52, 29},
        {53, 29},
        {54, 29},
        {55, 29},
        {56, 29},
        {57, 29},
        {48, 29},
        {49, 29},
        {50, 29},
        {51, 29},
        {52, 29},
        {53, 29},
        {54, 29},
        {55, 29},
        {56, 29},
        {57, 29},
        {48, 23},
        {49, 23},
        {50, 23},
        {51, 23},
        {52, 23},
        {53, 23},
        {54, 23},
        {55, 23},
        {56, 23},
        {57, 23},
        {95, 23},
        {97, 23},
        {98, 23},
        {99, 23},
        {100, 23},
        {101, 23},
        {102, 23},
        {103, 23},
        {104, 23},
        {105, 23},
        {106, 23},
        {107, 23},
        {108, 23},
        {109, 23},
        {110, 23},
        {111, 23},
        {112, 23},
        {113, 23},
        {114, 23},
        {115, 23},
        {116, 23},
        {117, 23},
        {118, 23},
        {119, 23},
        {120, 23},
        {121, 23},
        {122, 23},
        {9, 36},
        {10, 36},
        {13, 36},
        {32, 36},
        {33, 36},
        {34, 36},
        {35, 38},
        {36, 36},
        {37, 36},
        {38, 36},
        {39, 36},
        {40, 36},
        {41, 36},
        {42, 36},
        {43, 36},
        {44, 36},
        {45, 36},
        {46, 36},
        {47, 36},
        {48, 36},
        {49, 36},
        {50, 36},
        {51, 36},
        {52, 36},
        {53, 36},
        {54, 36},
        {55, 36},
        {56, 36},
        {57, 36},
        {58, 36},
        {59, 36},
        {60, 36},
        {61, 36},
        {62, 36},
        {63, 36},
        {64, 36},
        {65, 36},
        {66, 36},
        {67, 36},
        {68, 36},
        {69, 36},
        {70, 36},
        {71, 36},
        {72, 36},
        {73, 36},
        {74, 36},
        {75, 36},
        {76, 36},
        {77, 36},
        {78, 36},
        {79, 36},
        {80, 36},
        {81, 36},
        {82, 36},
        {83, 36},
        {84, 36},
        {85, 36},
        {86, 36},
        {87, 36},
        {88, 36},
        {89, 36},
        {90, 36},
        {91, 36},
        {92, 36},
        {93, 36},
        {94, 36},
        {95, 36},
        {96, 36},
        {97, 36},
        {98, 36},
        {99, 36},
        {100, 36},
        {101, 36},
        {102, 36},
        {103, 36},
        {104, 36},
        {105, 36},
        {106, 36},
        {107, 36},
        {108, 36},
        {109, 36},
        {110, 36},
        {111, 36},
        {112, 36},
        {113, 36},
        {114, 36},
        {115, 36},
        {116, 36},
        {117, 36},
        {118, 36},
        {119, 36},
        {120, 36},
        {121, 36},
        {122, 36},
        {123, 36},
        {124, 39},
        {125, 36},
        {126, 36},
        {161, 36},
        {162, 36},
        {163, 36},
        {164, 36},
        {165, 36},
        {166, 36},
        {167, 36},
        {168, 36},
        {169, 36},
        {170, 36},
        {171, 36},
        {172, 36},
        {173, 36},
        {174, 36},
        {175, 36},
        {176, 36},
        {177, 36},
        {178, 36},
        {179, 36},
        {180, 36},
        {181, 36},
        {182, 36},
        {183, 36},
        {184, 36},
        {185, 36},
        {186, 36},
        {187, 36},
        {188, 36},
        {189, 36},
        {190, 36},
        {191, 36},
        {192, 36},
        {193, 36},
        {194, 36},
        {195, 36},
        {196, 36},
        {197, 36},
        {198, 36},
        {199, 36},
        {200, 36},
        {201, 36},
        {202, 36},
        {203, 36},
        {204, 36},
        {205, 36},
        {206, 36},
        {207, 36},
        {208, 36},
        {209, 36},
        {210, 36},
        {211, 36},
        {212, 36},
        {213, 36},
        {214, 36},
        {215, 36},
        {216, 36},
        {217, 36},
        {218, 36},
        {219, 36},
        {220, 36},
        {221, 36},
        {222, 36},
        {223, 36},
        {224, 36},
        {225, 36},
        {226, 36},
        {227, 36},
        {228, 36},
        {229, 36},
        {230, 36},
        {231, 36},
        {232, 36},
        {233, 36},
        {234, 36},
        {235, 36},
        {236, 36},
        {237, 36},
        {238, 36},
        {239, 36},
        {240, 36},
        {241, 36},
        {242, 36},
        {243, 36},
        {244, 36},
        {245, 36},
        {246, 36},
        {247, 36},
        {248, 36},
        {249, 36},
        {250, 36},
        {251, 36},
        {252, 36},
        {253, 36},
        {254, 36},
        {255, 36},
        {48, 37},
        {49, 29},
        {50, 29},
        {51, 29},
        {52, 29},
        {53, 29},
        {54, 29},
        {55, 29},
        {56, 29},
        {57, 29},
        {35, 38},
        {124, 40},
        {35, 41},
        {9, 36},
        {10, 36},
        {13, 36},
        {32, 36},
        {33, 36},
        {34, 36},
        {36, 36},
        {37, 36},
        {38, 36},
        {39, 36},
        {40, 36},
        {41, 36},
        {42, 36},
        {43, 36},
        {44, 36},
        {45, 36},
        {46, 36},
        {47, 36},
        {48, 36},
        {49, 36},
        {50, 36},
        {51, 36},
        {52, 36},
        {53, 36},
        {54, 36},
        {55, 36},
        {56, 36},
        {57, 36},
        {58, 36},
        {59, 36},
        {60, 36},
        {61, 36},
        {62, 36},
        {63, 36},
        {64, 36},
        {65, 36},
        {66, 36},
        {67, 36},
        {68, 36},
        {69, 36},
        {70, 36},
        {71, 36},
        {72, 36},
        {73, 36},
        {74, 36},
        {75, 36},
        {76, 36},
        {77, 36},
        {78, 36},
        {79, 36},
        {80, 36},
        {81, 36},
        {82, 36},
        {83, 36},
        {84, 36},
        {85, 36},
        {86, 36},
        {87, 36},
        {88, 36},
        {89, 36},
        {90, 36},
        {91, 36},
        {92, 36},
        {93, 36},
        {94, 36},
        {95, 36},
        {96, 36},
        {97, 36},
        {98, 36},
        {99, 36},
        {100, 36},
        {101, 36},
        {102, 36},
        {103, 36},
        {104, 36},
        {105, 36},
        {106, 36},
        {107, 36},
        {108, 36},
        {109, 36},
        {110, 36},
        {111, 36},
        {112, 36},
        {113, 36},
        {114, 36},
        {115, 36},
        {116, 36},
        {117, 36},
        {118, 36},
        {119, 36},
        {120, 36},
        {121, 36},
        {122, 36},
        {123, 36},
        {125, 36},
        {126, 36},
        {161, 36},
        {162, 36},
        {163, 36},
        {164, 36},
        {165, 36},
        {166, 36},
        {167, 36},
        {168, 36},
        {169, 36},
        {170, 36},
        {171, 36},
        {172, 36},
        {173, 36},
        {174, 36},
        {175, 36},
        {176, 36},
        {177, 36},
        {178, 36},
        {179, 36},
        {180, 36},
        {181, 36},
        {182, 36},
        {183, 36},
        {184, 36},
        {185, 36},
        {186, 36},
        {187, 36},
        {188, 36},
        {189, 36},
        {190, 36},
        {191, 36},
        {192, 36},
        {193, 36},
        {194, 36},
        {195, 36},
        {196, 36},
        {197, 36},
        {198, 36},
        {199, 36},
        {200, 36},
        {201, 36},
        {202, 36},
        {203, 36},
        {204, 36},
        {205, 36},
        {206, 36},
        {207, 36},
        {208, 36},
        {209, 36},
        {210, 36},
        {211, 36},
        {212, 36},
        {213, 36},
        {214, 36},
        {215, 36},
        {216, 36},
        {217, 36},
        {218, 36},
        {219, 36},
        {220, 36},
        {221, 36},
        {222, 36},
        {223, 36},
        {224, 36},
        {225, 36},
        {226, 36},
        {227, 36},
        {228, 36},
        {229, 36},
        {230, 36},
        {231, 36},
        {232, 36},
        {233, 36},
        {234, 36},
        {235, 36},
        {236, 36},
        {237, 36},
        {238, 36},
        {239, 36},
        {240, 36},
        {241, 36},
        {242, 36},
        {243, 36},
        {244, 36},
        {245, 36},
        {246, 36},
        {247, 36},
        {248, 36},
        {249, 36},
        {250, 36},
        {251, 36},
        {252, 36},
        {253, 36},
        {254, 36},
        {255, 36}
    };

        public int[] TOKEN_STATE = { 3, 0, -1, -1, -1, 35, 36, 32, 30, 43, 31, 44, 33, 3, 46, 45, 39, 47, 41, 34, 2, -1, 50, 2, 38, 5, -1, 48, 49, 4, -1, 40, 37, 42, 6, 2, -1, -1, -1, -1, -1, 7 };

        public int[] SPECIAL_CASES_INDEXES =
            {0, 0, 0, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22, 22  };

        public string[] SPECIAL_CASES_KEYS =
            {  "and", "begin", "bool", "char", "end", "false", "float", "forward", "ifFalseDo", "ifTrueDo", "int", "main", "module", "not", "or", "read", "string", "true", "voidentificador", "whileFalseDo", "whileTrueDo", "write" };

        public int[] SPECIAL_CASES_VALUES =
            {  8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29 };

        public string[] SCANNER_ERROR =
        {
          "Caractere não esperado",
        "",
        "Erro identificando \"!=\"",
        "Erro identificando constanteString",
        "Erro identificando bloco",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "",
        "Erro identificando constanteCaractere",
        "",
        "",
        "",
        "",
        "Erro identificando bloco",
        "",
        "",
        "",
        "Erro identificando constanteReal",
        "",
        "",
        "",
        "",
        "",
        "Erro identificando bloco",
        "Erro identificando constanteReal",
        "Erro identificando bloco",
        "Erro identificando bloco",
        "Erro identificando bloco",
        ""
    };
    }
}
